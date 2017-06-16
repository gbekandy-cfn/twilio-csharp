using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Preview.Sync.Service.SyncList 
{

    /// <summary>
    /// FetchSyncListItemOptions
    /// </summary>
    public class FetchSyncListItemOptions : IOptions<SyncListItemResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The list_sid
        /// </summary>
        public string PathListSid { get; }
        /// <summary>
        /// The index
        /// </summary>
        public int? PathIndex { get; }

        /// <summary>
        /// Construct a new FetchSyncListItemOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathListSid"> The list_sid </param>
        /// <param name="pathIndex"> The index </param>
        public FetchSyncListItemOptions(string pathServiceSid, string pathListSid, int? pathIndex)
        {
            PathServiceSid = pathServiceSid;
            PathListSid = pathListSid;
            PathIndex = pathIndex;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// DeleteSyncListItemOptions
    /// </summary>
    public class DeleteSyncListItemOptions : IOptions<SyncListItemResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The list_sid
        /// </summary>
        public string PathListSid { get; }
        /// <summary>
        /// The index
        /// </summary>
        public int? PathIndex { get; }

        /// <summary>
        /// Construct a new DeleteSyncListItemOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathListSid"> The list_sid </param>
        /// <param name="pathIndex"> The index </param>
        public DeleteSyncListItemOptions(string pathServiceSid, string pathListSid, int? pathIndex)
        {
            PathServiceSid = pathServiceSid;
            PathListSid = pathListSid;
            PathIndex = pathIndex;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// CreateSyncListItemOptions
    /// </summary>
    public class CreateSyncListItemOptions : IOptions<SyncListItemResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The list_sid
        /// </summary>
        public string PathListSid { get; }
        /// <summary>
        /// The data
        /// </summary>
        public object Data { get; }

        /// <summary>
        /// Construct a new CreateSyncListItemOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathListSid"> The list_sid </param>
        /// <param name="data"> The data </param>
        public CreateSyncListItemOptions(string pathServiceSid, string pathListSid, object data)
        {
            PathServiceSid = pathServiceSid;
            PathListSid = pathListSid;
            Data = data;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Data != null)
            {
                p.Add(new KeyValuePair<string, string>("Data", Serializers.JsonObject(Data)));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadSyncListItemOptions
    /// </summary>
    public class ReadSyncListItemOptions : ReadOptions<SyncListItemResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The list_sid
        /// </summary>
        public string PathListSid { get; }
        /// <summary>
        /// The order
        /// </summary>
        public SyncListItemResource.QueryResultOrderEnum Order { get; set; }
        /// <summary>
        /// The from
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// The bounds
        /// </summary>
        public SyncListItemResource.QueryFromBoundTypeEnum Bounds { get; set; }

        /// <summary>
        /// Construct a new ReadSyncListItemOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathListSid"> The list_sid </param>
        public ReadSyncListItemOptions(string pathServiceSid, string pathListSid)
        {
            PathServiceSid = pathServiceSid;
            PathListSid = pathListSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Order != null)
            {
                p.Add(new KeyValuePair<string, string>("Order", Order.ToString()));
            }

            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From));
            }

            if (Bounds != null)
            {
                p.Add(new KeyValuePair<string, string>("Bounds", Bounds.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// UpdateSyncListItemOptions
    /// </summary>
    public class UpdateSyncListItemOptions : IOptions<SyncListItemResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The list_sid
        /// </summary>
        public string PathListSid { get; }
        /// <summary>
        /// The index
        /// </summary>
        public int? PathIndex { get; }
        /// <summary>
        /// The data
        /// </summary>
        public object Data { get; }

        /// <summary>
        /// Construct a new UpdateSyncListItemOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathListSid"> The list_sid </param>
        /// <param name="pathIndex"> The index </param>
        /// <param name="data"> The data </param>
        public UpdateSyncListItemOptions(string pathServiceSid, string pathListSid, int? pathIndex, object data)
        {
            PathServiceSid = pathServiceSid;
            PathListSid = pathListSid;
            PathIndex = pathIndex;
            Data = data;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Data != null)
            {
                p.Add(new KeyValuePair<string, string>("Data", Serializers.JsonObject(Data)));
            }

            return p;
        }
    }

}