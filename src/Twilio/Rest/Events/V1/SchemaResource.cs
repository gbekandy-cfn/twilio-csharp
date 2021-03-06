/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// SchemaResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Events.V1
{

    public class SchemaResource : Resource
    {
        private static Request BuildFetchRequest(FetchSchemaOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Events,
                "/v1/Schemas/" + options.PathId + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Fetch a specific schema with its nested versions.
        /// </summary>
        /// <param name="options"> Fetch Schema parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Schema </returns>
        public static SchemaResource Fetch(FetchSchemaOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific schema with its nested versions.
        /// </summary>
        /// <param name="options"> Fetch Schema parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Schema </returns>
        public static async System.Threading.Tasks.Task<SchemaResource> FetchAsync(FetchSchemaOptions options,
                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a specific schema with its nested versions.
        /// </summary>
        /// <param name="pathId"> The unique identifier of the schema. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Schema </returns>
        public static SchemaResource Fetch(string pathId, ITwilioRestClient client = null)
        {
            var options = new FetchSchemaOptions(pathId);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific schema with its nested versions.
        /// </summary>
        /// <param name="pathId"> The unique identifier of the schema. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Schema </returns>
        public static async System.Threading.Tasks.Task<SchemaResource> FetchAsync(string pathId,
                                                                                   ITwilioRestClient client = null)
        {
            var options = new FetchSchemaOptions(pathId);
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a SchemaResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SchemaResource object represented by the provided JSON </returns>
        public static SchemaResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<SchemaResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// Schema Identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }
        /// <summary>
        /// The URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// Nested resource URLs.
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }
        /// <summary>
        /// The date that the last schema version was created.
        /// </summary>
        [JsonProperty("last_created")]
        public DateTime? LastCreated { get; private set; }
        /// <summary>
        /// Last schema version.
        /// </summary>
        [JsonProperty("last_version")]
        public int? LastVersion { get; private set; }

        private SchemaResource()
        {

        }
    }

}