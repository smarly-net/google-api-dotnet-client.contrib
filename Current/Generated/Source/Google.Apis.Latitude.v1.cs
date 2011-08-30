//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Latitude.v1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    /// <summary>A Location resource identifies a user&apos;s position at a particular time. It may include metadata about the user&apos;s position, such as a venue if the location was recorded at the time of a check-in.</summary>
    public class LatitudeCurrentlocationResourceJson : Google.Apis.Requests.IDirectResponseSchema {
        
        private string accuracy;
        
        private string activityId;
        
        private string altitude;
        
        private string altitudeAccuracy;
        
        private string heading;
        
        private string kind;
        
        private string latitude;
        
        private string longitude;
        
        private string speed;
        
        private string timestampMs;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        /// <summary>Accuracy of the latitude and longitude coordinates, in non-negative meters. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accuracy")]
        public virtual string Accuracy {
            get {
                return this.accuracy;
            }
            set {
                this.accuracy = value;
            }
        }
        
        /// <summary>Unique ID of the Buzz message that corresponds to the check-in associated with this location. Available only for check-in locations. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityId")]
        public virtual string ActivityId {
            get {
                return this.activityId;
            }
            set {
                this.activityId = value;
            }
        }
        
        /// <summary>Altitude of the location, in meters. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altitude")]
        public virtual string Altitude {
            get {
                return this.altitude;
            }
            set {
                this.altitude = value;
            }
        }
        
        /// <summary>Accuracy of the altitude value, in meters. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altitudeAccuracy")]
        public virtual string AltitudeAccuracy {
            get {
                return this.altitudeAccuracy;
            }
            set {
                this.altitudeAccuracy = value;
            }
        }
        
        /// <summary>Direction of travel of the user when this location was recorded. In degrees, clockwise relative to true north. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heading")]
        public virtual string Heading {
            get {
                return this.heading;
            }
            set {
                this.heading = value;
            }
        }
        
        /// <summary>Kind of this item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        /// <summary>Latitude of the location, in decimal degrees.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual string Latitude {
            get {
                return this.latitude;
            }
            set {
                this.latitude = value;
            }
        }
        
        /// <summary>Longitude of the location, in decimal degrees.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual string Longitude {
            get {
                return this.longitude;
            }
            set {
                this.longitude = value;
            }
        }
        
        /// <summary>Ground speed of the user at the time this location was recorded, in meters per second. Non-negative. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speed")]
        public virtual string Speed {
            get {
                return this.speed;
            }
            set {
                this.speed = value;
            }
        }
        
        /// <summary>Timestamp of the Location Resource, in milliseconds since the epoch (UTC). This is also the Location Resource&apos;s unique id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampMs")]
        public virtual string TimestampMs {
            get {
                return this.timestampMs;
            }
            set {
                this.timestampMs = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this.eTag;
            }
            set {
                this.eTag = value;
            }
        }
    }
    
    /// <summary>A Location resource identifies a user&apos;s position at a particular time. It may include metadata about the user&apos;s position, such as a venue if the location was recorded at the time of a check-in.</summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema {
        
        private string accuracy;
        
        private string activityId;
        
        private string altitude;
        
        private string altitudeAccuracy;
        
        private string heading;
        
        private string kind;
        
        private string latitude;
        
        private string longitude;
        
        private string speed;
        
        private string timestampMs;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        /// <summary>Accuracy of the latitude and longitude coordinates, in non-negative meters. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accuracy")]
        public virtual string Accuracy {
            get {
                return this.accuracy;
            }
            set {
                this.accuracy = value;
            }
        }
        
        /// <summary>Unique ID of the Buzz message that corresponds to the check-in associated with this location. Available only for check-in locations. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityId")]
        public virtual string ActivityId {
            get {
                return this.activityId;
            }
            set {
                this.activityId = value;
            }
        }
        
        /// <summary>Altitude of the location, in meters. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altitude")]
        public virtual string Altitude {
            get {
                return this.altitude;
            }
            set {
                this.altitude = value;
            }
        }
        
        /// <summary>Accuracy of the altitude value, in meters. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altitudeAccuracy")]
        public virtual string AltitudeAccuracy {
            get {
                return this.altitudeAccuracy;
            }
            set {
                this.altitudeAccuracy = value;
            }
        }
        
        /// <summary>Direction of travel of the user when this location was recorded. In degrees, clockwise relative to true north. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heading")]
        public virtual string Heading {
            get {
                return this.heading;
            }
            set {
                this.heading = value;
            }
        }
        
        /// <summary>Kind of this item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        /// <summary>Latitude of the location, in decimal degrees.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual string Latitude {
            get {
                return this.latitude;
            }
            set {
                this.latitude = value;
            }
        }
        
        /// <summary>Longitude of the location, in decimal degrees.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual string Longitude {
            get {
                return this.longitude;
            }
            set {
                this.longitude = value;
            }
        }
        
        /// <summary>Ground speed of the user at the time this location was recorded, in meters per second. Non-negative. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speed")]
        public virtual string Speed {
            get {
                return this.speed;
            }
            set {
                this.speed = value;
            }
        }
        
        /// <summary>Timestamp of the Location Resource, in milliseconds since the epoch (UTC). This is also the Location Resource&apos;s unique id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampMs")]
        public virtual string TimestampMs {
            get {
                return this.timestampMs;
            }
            set {
                this.timestampMs = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this.eTag;
            }
            set {
                this.eTag = value;
            }
        }
    }
    
    public class LocationFeed : Google.Apis.Requests.IDirectResponseSchema {
        
        private IList<Location> items;
        
        private string kind;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual IList<Location> Items {
            get {
                return this.items;
            }
            set {
                this.items = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this.eTag;
            }
            set {
                this.eTag = value;
            }
        }
    }
}
namespace Google.Apis.Latitude.v1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class LatitudeService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string DiscoveryDocument = "{\"kind\":\"discovery#restDescription\",\"id\":\"latitude:v1\",\"name\":\"latitude\",\"version" +
            "\":\"v1\",\"title\":\"Google Latitude API\",\"description\":\"Lets you read and update you" +
            "r current location and work with your location history\",\"icons\":{\"x16\":\"http://w" +
            "ww.google.com/images/icons/product/search-16.gif\",\"x32\":\"http://www.google.com/i" +
            "mages/icons/product/search-32.gif\"},\"documentationLink\":\"http://code.google.com/" +
            "apis/latitude/v1/using_rest.html\",\"labels\":[\"labs\"],\"protocol\":\"rest\",\"basePath\"" +
            ":\"/latitude/v1/\",\"parameters\":{\"alt\":{\"type\":\"string\",\"description\":\"Data format" +
            " for the response.\",\"default\":\"json\",\"enum\":[\"atom\",\"json\"],\"enumDescriptions\":[" +
            "\"Responses with Content-Type of application/atom+xml\",\"Responses with Content-Ty" +
            "pe of application/json\"],\"location\":\"query\"},\"fields\":{\"type\":\"string\",\"descript" +
            "ion\":\"Selector specifying which fields to include in a partial response.\",\"locat" +
            "ion\":\"query\"},\"key\":{\"type\":\"string\",\"description\":\"API key. Your API key identi" +
            "fies your project and provides you with API access, quota, and reports. Required" +
            " unless you provide an OAuth 2.0 token.\",\"location\":\"query\"},\"oauth_token\":{\"typ" +
            "e\":\"string\",\"description\":\"OAuth 2.0 token for the current user.\",\"location\":\"qu" +
            "ery\"},\"prettyPrint\":{\"type\":\"boolean\",\"description\":\"Returns response with inden" +
            "tations and line breaks.\",\"default\":\"false\",\"location\":\"query\"},\"userIp\":{\"type\"" +
            ":\"string\",\"description\":\"IP address of the site where the request originates. Us" +
            "e this if you want to enforce per-user limits.\",\"location\":\"query\"}},\"auth\":{\"oa" +
            "uth2\":{\"scopes\":{\"https://www.googleapis.com/auth/latitude.all.best\":{\"descripti" +
            "on\":\"Manage your best-available location and location history\"},\"https://www.goo" +
            "gleapis.com/auth/latitude.all.city\":{\"description\":\"Manage your city-level locat" +
            "ion and location history\"},\"https://www.googleapis.com/auth/latitude.current.bes" +
            "t\":{\"description\":\"Manage your best-available location\"},\"https://www.googleapis" +
            ".com/auth/latitude.current.city\":{\"description\":\"Manage your city-level location" +
            "\"}}}},\"features\":[\"dataWrapper\"],\"schemas\":{\"LatitudeCurrentlocationResourceJson" +
            "\":{\"$ref\":\"Location\"},\"Location\":{\"id\":\"Location\",\"type\":\"object\",\"description\":" +
            "\"A Location resource identifies a user\'s position at a particular time. It may i" +
            "nclude metadata about the user\'s position, such as a venue if the location was r" +
            "ecorded at the time of a check-in.\",\"properties\":{\"accuracy\":{\"type\":\"any\",\"desc" +
            "ription\":\"Accuracy of the latitude and longitude coordinates, in non-negative me" +
            "ters. Optional.\"},\"activityId\":{\"type\":\"any\",\"description\":\"Unique ID of the Buz" +
            "z message that corresponds to the check-in associated with this location. Availa" +
            "ble only for check-in locations. Optional.\"},\"altitude\":{\"type\":\"any\",\"descripti" +
            "on\":\"Altitude of the location, in meters. Optional.\"},\"altitudeAccuracy\":{\"type\"" +
            ":\"any\",\"description\":\"Accuracy of the altitude value, in meters. Optional.\"},\"he" +
            "ading\":{\"type\":\"any\",\"description\":\"Direction of travel of the user when this lo" +
            "cation was recorded. In degrees, clockwise relative to true north. Optional.\"},\"" +
            "kind\":{\"type\":\"string\",\"description\":\"Kind of this item.\",\"default\":\"latitude#lo" +
            "cation\"},\"latitude\":{\"type\":\"any\",\"description\":\"Latitude of the location, in de" +
            "cimal degrees.\"},\"longitude\":{\"type\":\"any\",\"description\":\"Longitude of the locat" +
            "ion, in decimal degrees.\"},\"speed\":{\"type\":\"any\",\"description\":\"Ground speed of " +
            "the user at the time this location was recorded, in meters per second. Non-negat" +
            "ive. Optional.\"},\"timestampMs\":{\"type\":\"any\",\"description\":\"Timestamp of the Loc" +
            "ation Resource, in milliseconds since the epoch (UTC). This is also the Location" +
            " Resource\'s unique id.\"}}},\"LocationFeed\":{\"id\":\"LocationFeed\",\"type\":\"object\",\"" +
            "properties\":{\"items\":{\"type\":\"array\",\"items\":{\"$ref\":\"Location\"}},\"kind\":{\"type\"" +
            ":\"string\",\"default\":\"latitude#locationFeed\"}}}},\"resources\":{\"currentLocation\":{" +
            "\"methods\":{\"delete\":{\"id\":\"latitude.currentLocation.delete\",\"path\":\"currentLocat" +
            "ion\",\"httpMethod\":\"DELETE\",\"description\":\"Deletes the authenticated user\'s curre" +
            "nt location.\",\"scopes\":[\"https://www.googleapis.com/auth/latitude.all.best\",\"htt" +
            "ps://www.googleapis.com/auth/latitude.all.city\",\"https://www.googleapis.com/auth" +
            "/latitude.current.best\",\"https://www.googleapis.com/auth/latitude.current.city\"]" +
            "},\"get\":{\"id\":\"latitude.currentLocation.get\",\"path\":\"currentLocation\",\"httpMetho" +
            "d\":\"GET\",\"description\":\"Returns the authenticated user\'s current location.\",\"par" +
            "ameters\":{\"granularity\":{\"type\":\"string\",\"description\":\"Granularity of the reque" +
            "sted location.\",\"location\":\"query\"}},\"response\":{\"$ref\":\"LatitudeCurrentlocation" +
            "ResourceJson\"},\"scopes\":[\"https://www.googleapis.com/auth/latitude.all.best\",\"ht" +
            "tps://www.googleapis.com/auth/latitude.all.city\",\"https://www.googleapis.com/aut" +
            "h/latitude.current.best\",\"https://www.googleapis.com/auth/latitude.current.city\"" +
            "]},\"insert\":{\"id\":\"latitude.currentLocation.insert\",\"path\":\"currentLocation\",\"ht" +
            "tpMethod\":\"POST\",\"description\":\"Updates or creates the user\'s current location.\"" +
            ",\"request\":{\"$ref\":\"LatitudeCurrentlocationResourceJson\"},\"response\":{\"$ref\":\"La" +
            "titudeCurrentlocationResourceJson\"},\"scopes\":[\"https://www.googleapis.com/auth/l" +
            "atitude.all.best\",\"https://www.googleapis.com/auth/latitude.all.city\",\"https://w" +
            "ww.googleapis.com/auth/latitude.current.best\",\"https://www.googleapis.com/auth/l" +
            "atitude.current.city\"]}}},\"location\":{\"methods\":{\"delete\":{\"id\":\"latitude.locati" +
            "on.delete\",\"path\":\"location/{locationId}\",\"httpMethod\":\"DELETE\",\"description\":\"D" +
            "eletes a location from the user\'s location history.\",\"parameters\":{\"locationId\":" +
            "{\"type\":\"string\",\"description\":\"Timestamp of the location to delete (ms since ep" +
            "och).\",\"required\":true,\"location\":\"path\"}},\"parameterOrder\":[\"locationId\"],\"scop" +
            "es\":[\"https://www.googleapis.com/auth/latitude.all.best\",\"https://www.googleapis" +
            ".com/auth/latitude.all.city\"]},\"get\":{\"id\":\"latitude.location.get\",\"path\":\"locat" +
            "ion/{locationId}\",\"httpMethod\":\"GET\",\"description\":\"Reads a location from the us" +
            "er\'s location history.\",\"parameters\":{\"granularity\":{\"type\":\"string\",\"descriptio" +
            "n\":\"Granularity of the location to return.\",\"location\":\"query\"},\"locationId\":{\"t" +
            "ype\":\"string\",\"description\":\"Timestamp of the location to read (ms since epoch)." +
            "\",\"required\":true,\"location\":\"path\"}},\"parameterOrder\":[\"locationId\"],\"response\"" +
            ":{\"$ref\":\"Location\"},\"scopes\":[\"https://www.googleapis.com/auth/latitude.all.bes" +
            "t\",\"https://www.googleapis.com/auth/latitude.all.city\"]},\"insert\":{\"id\":\"latitud" +
            "e.location.insert\",\"path\":\"location\",\"httpMethod\":\"POST\",\"description\":\"Inserts " +
            "or updates a location in the user\'s location history.\",\"request\":{\"$ref\":\"Locati" +
            "on\"},\"response\":{\"$ref\":\"Location\"},\"scopes\":[\"https://www.googleapis.com/auth/l" +
            "atitude.all.best\",\"https://www.googleapis.com/auth/latitude.all.city\"]},\"list\":{" +
            "\"id\":\"latitude.location.list\",\"path\":\"location\",\"httpMethod\":\"GET\",\"description\"" +
            ":\"Lists the user\'s location history.\",\"parameters\":{\"granularity\":{\"type\":\"strin" +
            "g\",\"description\":\"Granularity of the requested locations.\",\"location\":\"query\"},\"" +
            "max-results\":{\"type\":\"string\",\"description\":\"Maximum number of locations to retu" +
            "rn.\",\"location\":\"query\"},\"max-time\":{\"type\":\"string\",\"description\":\"Maximum time" +
            "stamp of locations to return (ms since epoch).\",\"location\":\"query\"},\"min-time\":{" +
            "\"type\":\"string\",\"description\":\"Minimum timestamp of locations to return (ms sinc" +
            "e epoch).\",\"location\":\"query\"}},\"response\":{\"$ref\":\"LocationFeed\"},\"scopes\":[\"ht" +
            "tps://www.googleapis.com/auth/latitude.all.best\",\"https://www.googleapis.com/aut" +
            "h/latitude.all.city\"]}}}}}";
        
        private const string Version = "v1";
        
        private const string Name = "latitude";
        
        private const string BaseUri = "https://www.googleapis.com/latitude/v1/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string key;
        
        protected LatitudeService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.currentLocation = new CurrentLocationResource(this);
            this.location = new LocationResource(this);
        }
        
        public LatitudeService() : 
                this(Google.Apis.Authentication.NullAuthenticator.Instance) {
        }
        
        public LatitudeService(Google.Apis.Authentication.IAuthenticator authenticator) : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.StringDiscoveryDevice(DiscoveryDocument)).GetService(LatitudeService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV1_0(new System.Uri(LatitudeService.BaseUri))), authenticator) {
        }
        
        /// <summary>Sets the API-Key (or DeveloperKey) which this service uses for all requests</summary>
        public virtual string Key {
            get {
                return this.key;
            }
            set {
                this.key = value;
            }
        }
        
        public virtual Google.Apis.Requests.IRequest CreateRequest(string resource, string method) {
            Google.Apis.Requests.IRequest request = this.genericService.CreateRequest(resource, method);
            if (!string.IsNullOrEmpty(Key)) {
                request = request.WithKey(this.Key);
            }
            return request.WithAuthentication(authenticator);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            genericService.Serializer = serializer;
        }
        
        public virtual string SerializeObject(object obj) {
            return genericService.SerializeRequest(obj);
        }
        
        public virtual T DeserializeResponse<T>(Google.Apis.Requests.IResponse response)
         {
            return genericService.DeserializeResponse<T>(response);
        }
        
        /// <summary>A list of all OAuth2.0 scopes. Each of these scopes relates to a permission or group of permissions that different methods of this API may need.</summary>
        public enum Scopes {
            
            /// <summary>Manage your best-available location and location history</summary>
            [Google.Apis.Util.StringValueAttribute("https://www.googleapis.com/auth/latitude.all.best")]
            LatitudeAllBest,
            
            /// <summary>Manage your city-level location and location history</summary>
            [Google.Apis.Util.StringValueAttribute("https://www.googleapis.com/auth/latitude.all.city")]
            LatitudeAllCity,
            
            /// <summary>Manage your best-available location</summary>
            [Google.Apis.Util.StringValueAttribute("https://www.googleapis.com/auth/latitude.current.best")]
            LatitudeCurrentBest,
            
            /// <summary>Manage your city-level location</summary>
            [Google.Apis.Util.StringValueAttribute("https://www.googleapis.com/auth/latitude.current.city")]
            LatitudeCurrentCity,
        }
    }
    
    public class CurrentLocationResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "currentLocation";
        
        public CurrentLocationResource(LatitudeService service) {
            this.service = service;
        }
        
        /// <summary>Deletes the authenticated user&apos;s current location.</summary>
        public virtual DeleteRequest Delete() {
            return new DeleteRequest(service);
        }
        
        /// <summary>Returns the authenticated user&apos;s current location.</summary>
        public virtual GetRequest Get() {
            return new GetRequest(service);
        }
        
        /// <summary>Updates or creates the user&apos;s current location.</summary>
        public virtual InsertRequest Insert(Google.Apis.Latitude.v1.Data.LatitudeCurrentlocationResourceJson body) {
            return new InsertRequest(service, body);
        }
        
        public class DeleteRequest : Google.Apis.Requests.ServiceRequest<string> {
            
            public DeleteRequest(Google.Apis.Discovery.IRequestProvider service) : 
                    base(service) {
            }
            
            protected override string ResourcePath {
                get {
                    return "currentLocation";
                }
            }
            
            protected override string MethodName {
                get {
                    return "delete";
                }
            }
        }
        
        public class GetRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Latitude.v1.Data.LatitudeCurrentlocationResourceJson> {
            
            private string granularity;
            
            public GetRequest(Google.Apis.Discovery.IRequestProvider service) : 
                    base(service) {
            }
            
            /// <summary>Granularity of the requested location.</summary>
            [Google.Apis.Util.RequestParameterAttribute("granularity")]
            public virtual string Granularity {
                get {
                    return this.granularity;
                }
                set {
                    this.granularity = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "currentLocation";
                }
            }
            
            protected override string MethodName {
                get {
                    return "get";
                }
            }
        }
        
        public class InsertRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Latitude.v1.Data.LatitudeCurrentlocationResourceJson> {
            
            private Google.Apis.Latitude.v1.Data.LatitudeCurrentlocationResourceJson bodyValue;
            
            public InsertRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Latitude.v1.Data.LatitudeCurrentlocationResourceJson body) : 
                    base(service) {
                this.Body = body;
            }
            
            /// <summary>Gets/Sets the Body of this Request.</summary>
            public virtual Google.Apis.Latitude.v1.Data.LatitudeCurrentlocationResourceJson Body {
                get {
                    return this.bodyValue;
                }
                set {
                    this.bodyValue = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "currentLocation";
                }
            }
            
            protected override string MethodName {
                get {
                    return "insert";
                }
            }
            
            protected override object GetBody() {
                return this.Body;
            }
        }
    }
    
    public class LocationResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "location";
        
        public LocationResource(LatitudeService service) {
            this.service = service;
        }
        
        /// <summary>Deletes a location from the user&apos;s location history.</summary>
        /// <param name="locationId">Required - Timestamp of the location to delete (ms since epoch).</param>
        public virtual DeleteRequest Delete(string locationId) {
            return new DeleteRequest(service, locationId);
        }
        
        /// <summary>Reads a location from the user&apos;s location history.</summary>
        /// <param name="locationId">Required - Timestamp of the location to read (ms since epoch).</param>
        public virtual GetRequest Get(string locationId) {
            return new GetRequest(service, locationId);
        }
        
        /// <summary>Inserts or updates a location in the user&apos;s location history.</summary>
        public virtual InsertRequest Insert(Google.Apis.Latitude.v1.Data.Location body) {
            return new InsertRequest(service, body);
        }
        
        /// <summary>Lists the user&apos;s location history.</summary>
        public virtual ListRequest List() {
            return new ListRequest(service);
        }
        
        public class DeleteRequest : Google.Apis.Requests.ServiceRequest<string> {
            
            private string locationId;
            
            public DeleteRequest(Google.Apis.Discovery.IRequestProvider service, string locationId) : 
                    base(service) {
                this.locationId = locationId;
            }
            
            /// <summary>Timestamp of the location to delete (ms since epoch).</summary>
            [Google.Apis.Util.RequestParameterAttribute("locationId")]
            public virtual string LocationId {
                get {
                    return this.locationId;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "location";
                }
            }
            
            protected override string MethodName {
                get {
                    return "delete";
                }
            }
        }
        
        public class GetRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Latitude.v1.Data.Location> {
            
            private string granularity;
            
            private string locationId;
            
            public GetRequest(Google.Apis.Discovery.IRequestProvider service, string locationId) : 
                    base(service) {
                this.locationId = locationId;
            }
            
            /// <summary>Granularity of the location to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("granularity")]
            public virtual string Granularity {
                get {
                    return this.granularity;
                }
                set {
                    this.granularity = value;
                }
            }
            
            /// <summary>Timestamp of the location to read (ms since epoch).</summary>
            [Google.Apis.Util.RequestParameterAttribute("locationId")]
            public virtual string LocationId {
                get {
                    return this.locationId;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "location";
                }
            }
            
            protected override string MethodName {
                get {
                    return "get";
                }
            }
        }
        
        public class InsertRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Latitude.v1.Data.Location> {
            
            private Google.Apis.Latitude.v1.Data.Location bodyValue;
            
            public InsertRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Latitude.v1.Data.Location body) : 
                    base(service) {
                this.Body = body;
            }
            
            /// <summary>Gets/Sets the Body of this Request.</summary>
            public virtual Google.Apis.Latitude.v1.Data.Location Body {
                get {
                    return this.bodyValue;
                }
                set {
                    this.bodyValue = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "location";
                }
            }
            
            protected override string MethodName {
                get {
                    return "insert";
                }
            }
            
            protected override object GetBody() {
                return this.Body;
            }
        }
        
        public class ListRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Latitude.v1.Data.LocationFeed> {
            
            private string granularity;
            
            private string maxResults;
            
            private string maxTime;
            
            private string minTime;
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service) : 
                    base(service) {
            }
            
            /// <summary>Granularity of the requested locations.</summary>
            [Google.Apis.Util.RequestParameterAttribute("granularity")]
            public virtual string Granularity {
                get {
                    return this.granularity;
                }
                set {
                    this.granularity = value;
                }
            }
            
            /// <summary>Maximum number of locations to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("max-results")]
            public virtual string MaxResults {
                get {
                    return this.maxResults;
                }
                set {
                    this.maxResults = value;
                }
            }
            
            /// <summary>Maximum timestamp of locations to return (ms since epoch).</summary>
            [Google.Apis.Util.RequestParameterAttribute("max-time")]
            public virtual string MaxTime {
                get {
                    return this.maxTime;
                }
                set {
                    this.maxTime = value;
                }
            }
            
            /// <summary>Minimum timestamp of locations to return (ms since epoch).</summary>
            [Google.Apis.Util.RequestParameterAttribute("min-time")]
            public virtual string MinTime {
                get {
                    return this.minTime;
                }
                set {
                    this.minTime = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "location";
                }
            }
            
            protected override string MethodName {
                get {
                    return "list";
                }
            }
        }
    }
    
    public partial class LatitudeService {
        
        private const string Resource = "";
        
        private CurrentLocationResource currentLocation;
        
        private LocationResource location;
        
        private Google.Apis.Discovery.IRequestProvider service {
            get {
                return this;
            }
        }
        
        public virtual CurrentLocationResource CurrentLocation {
            get {
                return this.currentLocation;
            }
        }
        
        public virtual LocationResource Location {
            get {
                return this.location;
            }
        }
    }
}
