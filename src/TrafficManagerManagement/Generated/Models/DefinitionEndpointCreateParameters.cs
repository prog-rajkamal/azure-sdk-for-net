// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.WindowsAzure.Management.TrafficManager.Models;

namespace Microsoft.WindowsAzure.Management.TrafficManager.Models
{
    /// <summary>
    /// Specifies an Endpoint configuration
    /// </summary>
    public partial class DefinitionEndpointCreateParameters
    {
        private string _domainName;
        
        /// <summary>
        /// Required. Specifies the endpoint domain name.
        /// </summary>
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }
        
        private string _location;
        
        /// <summary>
        /// Optional. Specifies the location of an endpoint of type "Any". This
        /// is required for Performance policies. A list of possible values
        /// can be found under "Name" by calling List Locations:
        /// http://msdn.microsoft.com/en-us/library/gg441293.aspx
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private EndpointStatus _status;
        
        /// <summary>
        /// Required. Specifies the status of the monitoring endpoint. If set
        /// to Enabled, the endpoint is considered by the load balancing
        /// method and is monitored.
        /// </summary>
        public EndpointStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private EndpointType _type;
        
        /// <summary>
        /// Optional. The type of endpoint being added to the definition. If
        /// there is more than one AzureWebsite endpoint, they must be in
        /// different datacenters. This limitation doesn’t apply to cloud
        /// services. The default value is "CloudService".
        /// </summary>
        public EndpointType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        private int _weight;
        
        /// <summary>
        /// Optional. Specifies the weight of an endpoint in a weighted round
        /// robin policy. The valid range is for this value is [1, 1000]. The
        /// default is 1.
        /// </summary>
        public int Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DefinitionEndpointCreateParameters class.
        /// </summary>
        public DefinitionEndpointCreateParameters()
        {
        }
    }
}
