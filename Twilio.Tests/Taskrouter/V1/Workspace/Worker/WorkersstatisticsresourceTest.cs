using NUnit.Framework;
using Nunit.Mock;
using System;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Tests.Taskrouter.V1.Workspace.Worker {

    public class WorkersStatisticsTest {
        [Mocked]
        private TwilioRestClient twilioRestClient;
    
        [SetUp]
        public void SetUp() {
            Twilio.init("AC123", "AUTH TOKEN");
        }
    
        [TestCase]
        public void TestFetchRequest() {
            new NonStrictExpectations() {{
                Request request = new Request(HttpMethod.GET,
                                              TwilioRestClient.Domains.TASKROUTER,
                                              "/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Workers/Statistics",
                                              "AC123");
                
                
                twilioRestClient.request(request);
                times = 1;
                result = new Response("", 500);
                twilioRestClient.getAccountSid();
                result = "AC123";
            }};
            
            try {
                WorkersStatisticsResource.fetch("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").execute();
                fail("Expected TwilioException to be thrown for 500");
            } catch (TwilioException e) {}
        }
    
        [Test]
        public void TestFetchResponse() {
            new NonStrictExpectations() {{
                twilioRestClient.request((Request) any);
                result = new Response("{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"cumulative\": {\"activity_durations\": [{\"avg\": 0.0,\"friendly_name\": \"80fa2beb-3a05-11e5-8fc8-98e0d9a1eb73\",\"max\": 0,\"min\": 0,\"sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"total\": 0},{\"avg\": 0.0,\"friendly_name\": \"817ca1c5-3a05-11e5-9292-98e0d9a1eb73\",\"max\": 0,\"min\": 0,\"sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"total\": 0},{\"avg\": 0.0,\"friendly_name\": \"Busy\",\"max\": 0,\"min\": 0,\"sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"total\": 0},{\"avg\": 0.0,\"friendly_name\": \"Idle\",\"max\": 0,\"min\": 0,\"sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"total\": 0},{\"avg\": 0.0,\"friendly_name\": \"Offline\",\"max\": 0,\"min\": 0,\"sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"total\": 0},{\"avg\": 0.0,\"friendly_name\": \"Reserved\",\"max\": 0,\"min\": 0,\"sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"total\": 0}],\"end_time\": \"2015-08-18T16:35:33Z\",\"reservations_accepted\": 0,\"reservations_canceled\": 0,\"reservations_created\": 0,\"reservations_rejected\": 0,\"reservations_rescinded\": 0,\"reservations_timed_out\": 0,\"start_time\": \"2015-08-18T16:20:33Z\",\"tasks_assigned\": 0},\"realtime\": {\"activity_statistics\": [{\"friendly_name\": \"Offline\",\"sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"workers\": 1},{\"friendly_name\": \"Idle\",\"sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"workers\": 0},{\"friendly_name\": \"80fa2beb-3a05-11e5-8fc8-98e0d9a1eb73\",\"sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"workers\": 0},{\"friendly_name\": \"Reserved\",\"sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"workers\": 0},{\"friendly_name\": \"Busy\",\"sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"workers\": 0},{\"friendly_name\": \"817ca1c5-3a05-11e5-9292-98e0d9a1eb73\",\"sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"workers\": 0}],\"total_workers\": 1},\"workspace_sid\": \"WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}", TwilioRestClient.HTTP_STATUS_CODE_OK);
                twilioRestClient.getObjectMapper();
                result = new ObjectMapper();
            }};
            
            assertNotNull(WorkersStatisticsResource.fetch("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").execute());
        }
    }
}