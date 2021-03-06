/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// FieldResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Autopilot.V1.Assistant.Task
{

    public class FieldResource : Resource
    {
        private static Request BuildFetchRequest(FetchFieldOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Autopilot,
                "/v1/Assistants/" + options.PathAssistantSid + "/Tasks/" + options.PathTaskSid + "/Fields/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Field parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Field </returns>
        public static FieldResource Fetch(FetchFieldOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Field parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Field </returns>
        public static async System.Threading.Tasks.Task<FieldResource> FetchAsync(FetchFieldOptions options,
                                                                                  ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the
        ///                        resource to fetch </param>
        /// <param name="pathTaskSid"> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) resource
        ///                   associated with the Field resource to fetch </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Field </returns>
        public static FieldResource Fetch(string pathAssistantSid,
                                          string pathTaskSid,
                                          string pathSid,
                                          ITwilioRestClient client = null)
        {
            var options = new FetchFieldOptions(pathAssistantSid, pathTaskSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the
        ///                        resource to fetch </param>
        /// <param name="pathTaskSid"> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) resource
        ///                   associated with the Field resource to fetch </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Field </returns>
        public static async System.Threading.Tasks.Task<FieldResource> FetchAsync(string pathAssistantSid,
                                                                                  string pathTaskSid,
                                                                                  string pathSid,
                                                                                  ITwilioRestClient client = null)
        {
            var options = new FetchFieldOptions(pathAssistantSid, pathTaskSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadFieldOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Autopilot,
                "/v1/Assistants/" + options.PathAssistantSid + "/Tasks/" + options.PathTaskSid + "/Fields",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Field parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Field </returns>
        public static ResourceSet<FieldResource> Read(ReadFieldOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<FieldResource>.FromJson("fields", response.Content);
            return new ResourceSet<FieldResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Field parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Field </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FieldResource>> ReadAsync(ReadFieldOptions options,
                                                                                              ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<FieldResource>.FromJson("fields", response.Content);
            return new ResourceSet<FieldResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the
        ///                        resources to read. </param>
        /// <param name="pathTaskSid"> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) resource
        ///                   associated with the Field resources to read </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Field </returns>
        public static ResourceSet<FieldResource> Read(string pathAssistantSid,
                                                      string pathTaskSid,
                                                      int? pageSize = null,
                                                      long? limit = null,
                                                      ITwilioRestClient client = null)
        {
            var options = new ReadFieldOptions(pathAssistantSid, pathTaskSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the
        ///                        resources to read. </param>
        /// <param name="pathTaskSid"> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) resource
        ///                   associated with the Field resources to read </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Field </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FieldResource>> ReadAsync(string pathAssistantSid,
                                                                                              string pathTaskSid,
                                                                                              int? pageSize = null,
                                                                                              long? limit = null,
                                                                                              ITwilioRestClient client = null)
        {
            var options = new ReadFieldOptions(pathAssistantSid, pathTaskSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<FieldResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<FieldResource>.FromJson("fields", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<FieldResource> NextPage(Page<FieldResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Autopilot)
            );

            var response = client.Request(request);
            return Page<FieldResource>.FromJson("fields", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<FieldResource> PreviousPage(Page<FieldResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Autopilot)
            );

            var response = client.Request(request);
            return Page<FieldResource>.FromJson("fields", response.Content);
        }

        private static Request BuildCreateRequest(CreateFieldOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Autopilot,
                "/v1/Assistants/" + options.PathAssistantSid + "/Tasks/" + options.PathTaskSid + "/Fields",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Field parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Field </returns>
        public static FieldResource Create(CreateFieldOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Field parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Field </returns>
        public static async System.Threading.Tasks.Task<FieldResource> CreateAsync(CreateFieldOptions options,
                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the new
        ///                        resource </param>
        /// <param name="pathTaskSid"> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) resource
        ///                   associated with the new Field resource </param>
        /// <param name="fieldType"> The Field Type of this field </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the new resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Field </returns>
        public static FieldResource Create(string pathAssistantSid,
                                           string pathTaskSid,
                                           string fieldType,
                                           string uniqueName,
                                           ITwilioRestClient client = null)
        {
            var options = new CreateFieldOptions(pathAssistantSid, pathTaskSid, fieldType, uniqueName);
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the new
        ///                        resource </param>
        /// <param name="pathTaskSid"> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) resource
        ///                   associated with the new Field resource </param>
        /// <param name="fieldType"> The Field Type of this field </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the new resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Field </returns>
        public static async System.Threading.Tasks.Task<FieldResource> CreateAsync(string pathAssistantSid,
                                                                                   string pathTaskSid,
                                                                                   string fieldType,
                                                                                   string uniqueName,
                                                                                   ITwilioRestClient client = null)
        {
            var options = new CreateFieldOptions(pathAssistantSid, pathTaskSid, fieldType, uniqueName);
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteFieldOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Autopilot,
                "/v1/Assistants/" + options.PathAssistantSid + "/Tasks/" + options.PathTaskSid + "/Fields/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Field parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Field </returns>
        public static bool Delete(DeleteFieldOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Field parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Field </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteFieldOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the
        ///                        resources to delete </param>
        /// <param name="pathTaskSid"> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) resource
        ///                   associated with the Field resource to delete </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Field </returns>
        public static bool Delete(string pathAssistantSid,
                                  string pathTaskSid,
                                  string pathSid,
                                  ITwilioRestClient client = null)
        {
            var options = new DeleteFieldOptions(pathAssistantSid, pathTaskSid, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the
        ///                        resources to delete </param>
        /// <param name="pathTaskSid"> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) resource
        ///                   associated with the Field resource to delete </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Field </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathAssistantSid,
                                                                          string pathTaskSid,
                                                                          string pathSid,
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteFieldOptions(pathAssistantSid, pathTaskSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a FieldResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FieldResource object represented by the provided JSON </returns>
        public static FieldResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<FieldResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The Field Type of the field
        /// </summary>
        [JsonProperty("field_type")]
        public string FieldType { get; private set; }
        /// <summary>
        /// The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) resource associated with this Field
        /// </summary>
        [JsonProperty("task_sid")]
        public string TaskSid { get; private set; }
        /// <summary>
        /// The SID of the Assistant that is the parent of the Task associated with the resource
        /// </summary>
        [JsonProperty("assistant_sid")]
        public string AssistantSid { get; private set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// An application-defined string that uniquely identifies the resource
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// The absolute URL of the Field resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private FieldResource()
        {

        }
    }

}