/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Video.V1.Room.RoomParticipant 
{

    /// <summary>
    /// FetchPublishedTrackOptions
    /// </summary>
    public class FetchPublishedTrackOptions : IOptions<PublishedTrackResource> 
    {
        /// <summary>
        /// The room_sid
        /// </summary>
        public string PathRoomSid { get; }
        /// <summary>
        /// The participant_sid
        /// </summary>
        public string PathParticipantSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchPublishedTrackOptions
        /// </summary>
        /// <param name="pathRoomSid"> The room_sid </param>
        /// <param name="pathParticipantSid"> The participant_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchPublishedTrackOptions(string pathRoomSid, string pathParticipantSid, string pathSid)
        {
            PathRoomSid = pathRoomSid;
            PathParticipantSid = pathParticipantSid;
            PathSid = pathSid;
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
    /// ReadPublishedTrackOptions
    /// </summary>
    public class ReadPublishedTrackOptions : ReadOptions<PublishedTrackResource> 
    {
        /// <summary>
        /// The room_sid
        /// </summary>
        public string PathRoomSid { get; }
        /// <summary>
        /// The participant_sid
        /// </summary>
        public string PathParticipantSid { get; }

        /// <summary>
        /// Construct a new ReadPublishedTrackOptions
        /// </summary>
        /// <param name="pathRoomSid"> The room_sid </param>
        /// <param name="pathParticipantSid"> The participant_sid </param>
        public ReadPublishedTrackOptions(string pathRoomSid, string pathParticipantSid)
        {
            PathRoomSid = pathRoomSid;
            PathParticipantSid = pathParticipantSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}