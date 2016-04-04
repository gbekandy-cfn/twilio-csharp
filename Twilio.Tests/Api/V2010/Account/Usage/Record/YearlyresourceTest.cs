using NUnit.Framework;
using Nunit.Mock;
using System;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Tests.Api.V2010.Account.Usage.Record {

    public class YearlyTest {
        [Mocked]
        private TwilioRestClient twilioRestClient;
    
        [SetUp]
        public void SetUp() {
            Twilio.init("AC123", "AUTH TOKEN");
        }
    
        [TestCase]
        public void TestReadRequest() {
            new NonStrictExpectations() {{
                Request request = new Request(HttpMethod.GET,
                                              TwilioRestClient.Domains.API,
                                              "/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage/Records/Yearly.json",
                                              "AC123");
                
                request.addQueryParam("PageSize", "50");
                twilioRestClient.request(request);
                times = 1;
                result = new Response("", 500);
                twilioRestClient.getAccountSid();
                result = "AC123";
            }};
            
            try {
                YearlyResource.read("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").execute();
                fail("Expected TwilioException to be thrown for 500");
            } catch (TwilioException e) {}
        }
    
        [Test]
        public void TestReadFullResponse() {
            new NonStrictExpectations() {{
                twilioRestClient.request((Request) any);
                result = new Response("{\"end\": 0,\"first_page_uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage/Records/Yearly?Page=0&PageSize=1\",\"last_page_uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage/Records/Yearly?Page=344&PageSize=1\",\"next_page_uri\": null,\"num_pages\": 345,\"page\": 0,\"page_size\": 1,\"previous_page_uri\": null,\"start\": 0,\"total\": 345,\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage/Records/Yearly\",\"usage_records\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"api_version\": \"2010-04-01\",\"category\": \"sms-inbound-shortcode\",\"count\": \"0\",\"count_unit\": \"messages\",\"description\": \"Short Code Inbound SMS\",\"end_date\": \"2015-09-04\",\"price\": \"0\",\"price_unit\": \"usd\",\"start_date\": \"2015-01-01\",\"subresource_uris\": {\"all_time\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage/Records/AllTime.json?Category=sms-inbound-shortcode\",\"daily\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage/Records/Daily.json?Category=sms-inbound-shortcode\",\"last_month\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage/Records/LastMonth.json?Category=sms-inbound-shortcode\",\"monthly\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage/Records/Monthly.json?Category=sms-inbound-shortcode\",\"this_month\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage/Records/ThisMonth.json?Category=sms-inbound-shortcode\",\"today\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage/Records/Today.json?Category=sms-inbound-shortcode\",\"yearly\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage/Records/Yearly.json?Category=sms-inbound-shortcode\",\"yesterday\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage/Records/Yesterday.json?Category=sms-inbound-shortcode\"},\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage/Records/Yearly?Category=sms-inbound-shortcode&StartDate=2015-01-01&EndDate=2015-09-04\",\"usage\": \"0\",\"usage_unit\": \"messages\"}]}", TwilioRestClient.HTTP_STATUS_CODE_OK);
                twilioRestClient.getObjectMapper();
                result = new ObjectMapper();
            }};
            
            assertNotNull(YearlyResource.read("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").execute());
        }
    
        [Test]
        public void TestReadEmptyResponse() {
            new NonStrictExpectations() {{
                twilioRestClient.request((Request) any);
                result = new Response("{\"end\": 0,\"first_page_uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage/Records/Yearly?Page=0&PageSize=1\",\"last_page_uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage/Records/Yearly?Page=344&PageSize=1\",\"next_page_uri\": null,\"num_pages\": 345,\"page\": 0,\"page_size\": 1,\"previous_page_uri\": null,\"start\": 0,\"total\": 345,\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage/Records/Yearly\",\"usage_records\": []}", TwilioRestClient.HTTP_STATUS_CODE_OK);
                twilioRestClient.getObjectMapper();
                result = new ObjectMapper();
            }};
            
            assertNotNull(YearlyResource.read("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").execute());
        }
    }
}