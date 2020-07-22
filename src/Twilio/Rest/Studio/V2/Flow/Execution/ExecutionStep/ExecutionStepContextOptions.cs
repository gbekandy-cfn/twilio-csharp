/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Studio.V2.Flow.Execution.ExecutionStep
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Retrieve the context for an Execution Step.
    /// </summary>
    public class FetchExecutionStepContextOptions : IOptions<ExecutionStepContextResource>
    {
        /// <summary>
        /// The SID of the Flow
        /// </summary>
        public string PathFlowSid { get; }
        /// <summary>
        /// The SID of the Execution
        /// </summary>
        public string PathExecutionSid { get; }
        /// <summary>
        /// Step SID
        /// </summary>
        public string PathStepSid { get; }

        /// <summary>
        /// Construct a new FetchExecutionStepContextOptions
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow </param>
        /// <param name="pathExecutionSid"> The SID of the Execution </param>
        /// <param name="pathStepSid"> Step SID </param>
        public FetchExecutionStepContextOptions(string pathFlowSid, string pathExecutionSid, string pathStepSid)
        {
            PathFlowSid = pathFlowSid;
            PathExecutionSid = pathExecutionSid;
            PathStepSid = pathStepSid;
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

}