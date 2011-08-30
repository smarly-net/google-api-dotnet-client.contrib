//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Urlshortener.v1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class AnalyticsSnapshot {
        
        private IList<StringCount> browsers;
        
        private IList<StringCount> countries;
        
        private string longUrlClicks;
        
        private IList<StringCount> platforms;
        
        private IList<StringCount> referrers;
        
        private string shortUrlClicks;
        
        /// <summary>Top browsers, e.g. &quot;Chrome&quot;; sorted by (descending) click counts. Only present if this data is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("browsers")]
        public virtual IList<StringCount> Browsers {
            get {
                return this.browsers;
            }
            set {
                this.browsers = value;
            }
        }
        
        /// <summary>Top countries (expressed as country codes), e.g. &quot;US&quot; or &quot;DE&quot;; sorted by (descending) click counts. Only present if this data is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countries")]
        public virtual IList<StringCount> Countries {
            get {
                return this.countries;
            }
            set {
                this.countries = value;
            }
        }
        
        /// <summary>Number of clicks on all goo.gl short URLs pointing to this long URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longUrlClicks")]
        public virtual string LongUrlClicks {
            get {
                return this.longUrlClicks;
            }
            set {
                this.longUrlClicks = value;
            }
        }
        
        /// <summary>Top platforms or OSes, e.g. &quot;Windows&quot;; sorted by (descending) click counts. Only present if this data is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platforms")]
        public virtual IList<StringCount> Platforms {
            get {
                return this.platforms;
            }
            set {
                this.platforms = value;
            }
        }
        
        /// <summary>Top referring hosts, e.g. &quot;www.google.com&quot;; sorted by (descending) click counts. Only present if this data is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referrers")]
        public virtual IList<StringCount> Referrers {
            get {
                return this.referrers;
            }
            set {
                this.referrers = value;
            }
        }
        
        /// <summary>Number of clicks on this short URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortUrlClicks")]
        public virtual string ShortUrlClicks {
            get {
                return this.shortUrlClicks;
            }
            set {
                this.shortUrlClicks = value;
            }
        }
    }
    
    public class AnalyticsSummary {
        
        private AnalyticsSnapshot allTime;
        
        private AnalyticsSnapshot day;
        
        private AnalyticsSnapshot month;
        
        private AnalyticsSnapshot twoHours;
        
        private AnalyticsSnapshot week;
        
        [Newtonsoft.Json.JsonPropertyAttribute("allTime")]
        public virtual AnalyticsSnapshot AllTime {
            get {
                return this.allTime;
            }
            set {
                this.allTime = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual AnalyticsSnapshot Day {
            get {
                return this.day;
            }
            set {
                this.day = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual AnalyticsSnapshot Month {
            get {
                return this.month;
            }
            set {
                this.month = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("twoHours")]
        public virtual AnalyticsSnapshot TwoHours {
            get {
                return this.twoHours;
            }
            set {
                this.twoHours = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("week")]
        public virtual AnalyticsSnapshot Week {
            get {
                return this.week;
            }
            set {
                this.week = value;
            }
        }
    }
    
    public class StringCount {
        
        private string count;
        
        private string id;
        
        /// <summary>Number of clicks for this top entry, e.g. for this particular country or browser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual string Count {
            get {
                return this.count;
            }
            set {
                this.count = value;
            }
        }
        
        /// <summary>Label assigned to this top entry, e.g. &quot;US&quot; or &quot;Chrome&quot;.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
    }
    
    public class Url : Google.Apis.Requests.IDirectResponseSchema {
        
        private AnalyticsSummary analytics;
        
        private string created;
        
        private string id;
        
        private string kind;
        
        private string longUrl;
        
        private string status;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        [Newtonsoft.Json.JsonPropertyAttribute("analytics")]
        public virtual AnalyticsSummary Analytics {
            get {
                return this.analytics;
            }
            set {
                this.analytics = value;
            }
        }
        
        /// <summary>Time the short URL was created; ISO 8601 representation using the yyyy-MM-dd&apos;T&apos;HH:mm:ss.SSSZZ format, e.g. &quot;2010-10-14T19:01:24.944+00:00&quot;.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        public virtual string Created {
            get {
                return this.created;
            }
            set {
                this.created = value;
            }
        }
        
        /// <summary>Short URL, e.g. &quot;http://goo.gl/l6MS&quot;.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        
        /// <summary>The fixed string &quot;urlshortener#url&quot;.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        /// <summary>Long URL, e.g. &quot;http://www.google.com/&quot;. Might not be present if the status is &quot;REMOVED&quot;.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longUrl")]
        public virtual string LongUrl {
            get {
                return this.longUrl;
            }
            set {
                this.longUrl = value;
            }
        }
        
        /// <summary>Status of the target URL. Possible values: &quot;OK&quot;, &quot;MALWARE&quot;, &quot;PHISHING&quot;, or &quot;REMOVED&quot;. A URL might be marked &quot;REMOVED&quot; if it was flagged as spam, for example.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status {
            get {
                return this.status;
            }
            set {
                this.status = value;
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
    
    public class UrlHistory : Google.Apis.Requests.IDirectResponseSchema {
        
        private IList<Url> items;
        
        private System.Nullable<long> itemsPerPage;
        
        private string kind;
        
        private string nextPageToken;
        
        private System.Nullable<long> totalItems;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        /// <summary>A list of URL resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual IList<Url> Items {
            get {
                return this.items;
            }
            set {
                this.items = value;
            }
        }
        
        /// <summary>Number of items returned with each full &quot;page&quot; of results. Note that the last page could have fewer items than the &quot;itemsPerPage&quot; value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<long> ItemsPerPage {
            get {
                return this.itemsPerPage;
            }
            set {
                this.itemsPerPage = value;
            }
        }
        
        /// <summary>The fixed string &quot;urlshortener#urlHistory&quot;.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        /// <summary>A token to provide to get the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken {
            get {
                return this.nextPageToken;
            }
            set {
                this.nextPageToken = value;
            }
        }
        
        /// <summary>Total number of short URLs associated with this user (may be approximate).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
        public virtual System.Nullable<long> TotalItems {
            get {
                return this.totalItems;
            }
            set {
                this.totalItems = value;
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
namespace Google.Apis.Urlshortener.v1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class UrlshortenerService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string DiscoveryDocument = "{\"kind\":\"discovery#restDescription\",\"id\":\"urlshortener:v1\",\"name\":\"urlshortener\"," +
            "\"version\":\"v1\",\"title\":\"URL Shortener API\",\"description\":\"Lets you create, inspe" +
            "ct, and manage goo.gl short URLs\",\"icons\":{\"x16\":\"http://www.google.com/images/i" +
            "cons/product/search-16.gif\",\"x32\":\"http://www.google.com/images/icons/product/se" +
            "arch-32.gif\"},\"documentationLink\":\"http://code.google.com/apis/urlshortener/v1/g" +
            "etting_started.html\",\"labels\":[\"labs\"],\"protocol\":\"rest\",\"basePath\":\"/urlshorten" +
            "er/v1/\",\"parameters\":{\"alt\":{\"type\":\"string\",\"description\":\"Data format for the " +
            "response.\",\"default\":\"json\",\"enum\":[\"json\"],\"enumDescriptions\":[\"Responses with " +
            "Content-Type of application/json\"],\"location\":\"query\"},\"fields\":{\"type\":\"string\"" +
            ",\"description\":\"Selector specifying which fields to include in a partial respons" +
            "e.\",\"location\":\"query\"},\"key\":{\"type\":\"string\",\"description\":\"API key. Your API " +
            "key identifies your project and provides you with API access, quota, and reports" +
            ". Required unless you provide an OAuth 2.0 token.\",\"location\":\"query\"},\"oauth_to" +
            "ken\":{\"type\":\"string\",\"description\":\"OAuth 2.0 token for the current user.\",\"loc" +
            "ation\":\"query\"},\"prettyPrint\":{\"type\":\"boolean\",\"description\":\"Returns response " +
            "with indentations and line breaks.\",\"default\":\"true\",\"location\":\"query\"},\"userIp" +
            "\":{\"type\":\"string\",\"description\":\"IP address of the site where the request origi" +
            "nates. Use this if you want to enforce per-user limits.\",\"location\":\"query\"}},\"a" +
            "uth\":{\"oauth2\":{\"scopes\":{\"https://www.googleapis.com/auth/urlshortener\":{\"descr" +
            "iption\":\"Manage your goo.gl short URLs\"}}}},\"schemas\":{\"AnalyticsSnapshot\":{\"id\"" +
            ":\"AnalyticsSnapshot\",\"type\":\"object\",\"properties\":{\"browsers\":{\"type\":\"array\",\"d" +
            "escription\":\"Top browsers, e.g. \\\"Chrome\\\"; sorted by (descending) click counts." +
            " Only present if this data is available.\",\"items\":{\"$ref\":\"StringCount\"}},\"count" +
            "ries\":{\"type\":\"array\",\"description\":\"Top countries (expressed as country codes)," +
            " e.g. \\\"US\\\" or \\\"DE\\\"; sorted by (descending) click counts. Only present if thi" +
            "s data is available.\",\"items\":{\"$ref\":\"StringCount\"}},\"longUrlClicks\":{\"type\":\"s" +
            "tring\",\"description\":\"Number of clicks on all goo.gl short URLs pointing to this" +
            " long URL.\",\"format\":\"int64\"},\"platforms\":{\"type\":\"array\",\"description\":\"Top pla" +
            "tforms or OSes, e.g. \\\"Windows\\\"; sorted by (descending) click counts. Only pres" +
            "ent if this data is available.\",\"items\":{\"$ref\":\"StringCount\"}},\"referrers\":{\"ty" +
            "pe\":\"array\",\"description\":\"Top referring hosts, e.g. \\\"www.google.com\\\"; sorted " +
            "by (descending) click counts. Only present if this data is available.\",\"items\":{" +
            "\"$ref\":\"StringCount\"}},\"shortUrlClicks\":{\"type\":\"string\",\"description\":\"Number o" +
            "f clicks on this short URL.\",\"format\":\"int64\"}}},\"AnalyticsSummary\":{\"id\":\"Analy" +
            "ticsSummary\",\"type\":\"object\",\"properties\":{\"allTime\":{\"$ref\":\"AnalyticsSnapshot\"" +
            ",\"description\":\"Click analytics over all time.\"},\"day\":{\"$ref\":\"AnalyticsSnapsho" +
            "t\",\"description\":\"Click analytics over the last day.\"},\"month\":{\"$ref\":\"Analytic" +
            "sSnapshot\",\"description\":\"Click analytics over the last month.\"},\"twoHours\":{\"$r" +
            "ef\":\"AnalyticsSnapshot\",\"description\":\"Click analytics over the last two hours.\"" +
            "},\"week\":{\"$ref\":\"AnalyticsSnapshot\",\"description\":\"Click analytics over the las" +
            "t week.\"}}},\"StringCount\":{\"id\":\"StringCount\",\"type\":\"object\",\"properties\":{\"cou" +
            "nt\":{\"type\":\"string\",\"description\":\"Number of clicks for this top entry, e.g. fo" +
            "r this particular country or browser.\",\"format\":\"int64\"},\"id\":{\"type\":\"string\",\"" +
            "description\":\"Label assigned to this top entry, e.g. \\\"US\\\" or \\\"Chrome\\\".\"}}},\"" +
            "Url\":{\"id\":\"Url\",\"type\":\"object\",\"properties\":{\"analytics\":{\"$ref\":\"AnalyticsSum" +
            "mary\",\"description\":\"A summary of the click analytics for the short and long URL" +
            ". Might not be present if not requested or currently unavailable.\"},\"created\":{\"" +
            "type\":\"string\",\"description\":\"Time the short URL was created; ISO 8601 represent" +
            "ation using the yyyy-MM-dd\'T\'HH:mm:ss.SSSZZ format, e.g. \\\"2010-10-14T19:01:24.9" +
            "44+00:00\\\".\"},\"id\":{\"type\":\"string\",\"description\":\"Short URL, e.g. \\\"http://goo." +
            "gl/l6MS\\\".\"},\"kind\":{\"type\":\"string\",\"description\":\"The fixed string \\\"urlshorte" +
            "ner#url\\\".\",\"default\":\"urlshortener#url\"},\"longUrl\":{\"type\":\"string\",\"descriptio" +
            "n\":\"Long URL, e.g. \\\"http://www.google.com/\\\". Might not be present if the statu" +
            "s is \\\"REMOVED\\\".\"},\"status\":{\"type\":\"string\",\"description\":\"Status of the targe" +
            "t URL. Possible values: \\\"OK\\\", \\\"MALWARE\\\", \\\"PHISHING\\\", or \\\"REMOVED\\\". A URL" +
            " might be marked \\\"REMOVED\\\" if it was flagged as spam, for example.\"}}},\"UrlHis" +
            "tory\":{\"id\":\"UrlHistory\",\"type\":\"object\",\"properties\":{\"items\":{\"type\":\"array\",\"" +
            "description\":\"A list of URL resources.\",\"items\":{\"$ref\":\"Url\"}},\"itemsPerPage\":{" +
            "\"type\":\"integer\",\"description\":\"Number of items returned with each full \\\"page\\\"" +
            " of results. Note that the last page could have fewer items than the \\\"itemsPerP" +
            "age\\\" value.\",\"format\":\"int32\"},\"kind\":{\"type\":\"string\",\"description\":\"The fixed" +
            " string \\\"urlshortener#urlHistory\\\".\",\"default\":\"urlshortener#urlHistory\"},\"next" +
            "PageToken\":{\"type\":\"string\",\"description\":\"A token to provide to get the next pa" +
            "ge of results.\"},\"totalItems\":{\"type\":\"integer\",\"description\":\"Total number of s" +
            "hort URLs associated with this user (may be approximate).\",\"format\":\"int32\"}}}}," +
            "\"resources\":{\"url\":{\"methods\":{\"get\":{\"id\":\"urlshortener.url.get\",\"path\":\"url\",\"" +
            "httpMethod\":\"GET\",\"description\":\"Expands a short URL or gets creation time and a" +
            "nalytics.\",\"parameters\":{\"projection\":{\"type\":\"string\",\"description\":\"Additional" +
            " information to return.\",\"enum\":[\"ANALYTICS_CLICKS\",\"ANALYTICS_TOP_STRINGS\",\"FUL" +
            "L\"],\"enumDescriptions\":[\"Returns only click counts.\",\"Returns only top string co" +
            "unts.\",\"Returns the creation timestamp and all available analytics.\"],\"location\"" +
            ":\"query\"},\"shortUrl\":{\"type\":\"string\",\"description\":\"The short URL, including th" +
            "e protocol.\",\"required\":true,\"location\":\"query\"}},\"parameterOrder\":[\"shortUrl\"]," +
            "\"response\":{\"$ref\":\"Url\"}},\"insert\":{\"id\":\"urlshortener.url.insert\",\"path\":\"url\"" +
            ",\"httpMethod\":\"POST\",\"description\":\"Creates a new short URL.\",\"request\":{\"$ref\":" +
            "\"Url\"},\"response\":{\"$ref\":\"Url\"},\"scopes\":[\"https://www.googleapis.com/auth/urls" +
            "hortener\"]},\"list\":{\"id\":\"urlshortener.url.list\",\"path\":\"url/history\",\"httpMetho" +
            "d\":\"GET\",\"description\":\"Retrieves a list of URLs shortened by a user.\",\"paramete" +
            "rs\":{\"projection\":{\"type\":\"string\",\"description\":\"Additional information to retu" +
            "rn.\",\"enum\":[\"ANALYTICS_CLICKS\",\"FULL\"],\"enumDescriptions\":[\"Returns short URL c" +
            "lick counts.\",\"Returns short URL click counts.\"],\"location\":\"query\"},\"start-toke" +
            "n\":{\"type\":\"string\",\"description\":\"Token for requesting successive pages of resu" +
            "lts.\",\"location\":\"query\"}},\"response\":{\"$ref\":\"UrlHistory\"},\"scopes\":[\"https://w" +
            "ww.googleapis.com/auth/urlshortener\"]}}}}}";
        
        private const string Version = "v1";
        
        private const string Name = "urlshortener";
        
        private const string BaseUri = "https://www.googleapis.com/urlshortener/v1/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string key;
        
        protected UrlshortenerService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.url = new UrlResource(this);
        }
        
        public UrlshortenerService() : 
                this(Google.Apis.Authentication.NullAuthenticator.Instance) {
        }
        
        public UrlshortenerService(Google.Apis.Authentication.IAuthenticator authenticator) : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.StringDiscoveryDevice(DiscoveryDocument)).GetService(UrlshortenerService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV1_0(new System.Uri(UrlshortenerService.BaseUri))), authenticator) {
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
            
            /// <summary>Manage your goo.gl short URLs</summary>
            [Google.Apis.Util.StringValueAttribute("https://www.googleapis.com/auth/urlshortener")]
            Urlshortener,
        }
    }
    
    public class UrlResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "url";
        
        public UrlResource(UrlshortenerService service) {
            this.service = service;
        }
        
        /// <summary>Expands a short URL or gets creation time and analytics.</summary>
        /// <param name="shortUrl">Required - The short URL, including the protocol.</param>
        public virtual GetRequest Get(string shortUrl) {
            return new GetRequest(service, shortUrl);
        }
        
        /// <summary>Creates a new short URL.</summary>
        public virtual InsertRequest Insert(Google.Apis.Urlshortener.v1.Data.Url body) {
            return new InsertRequest(service, body);
        }
        
        /// <summary>Retrieves a list of URLs shortened by a user.</summary>
        public virtual ListRequest List() {
            return new ListRequest(service);
        }
        
        /// <summary>Additional information to return.</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Projection {
            
            /// <summary>Returns only click counts.</summary>
            [Google.Apis.Util.StringValueAttribute("ANALYTICS_CLICKS")]
            ANALYTICS_CLICKS,
            
            /// <summary>Returns only top string counts.</summary>
            [Google.Apis.Util.StringValueAttribute("ANALYTICS_TOP_STRINGS")]
            ANALYTICS_TOP_STRINGS,
            
            /// <summary>Returns the creation timestamp and all available analytics.</summary>
            [Google.Apis.Util.StringValueAttribute("FULL")]
            FULL,
        }
        
        /// <summary>Additional information to return.</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum ProjectionEnum {
            
            /// <summary>Returns short URL click counts.</summary>
            [Google.Apis.Util.StringValueAttribute("ANALYTICS_CLICKS")]
            ANALYTICS_CLICKS,
            
            /// <summary>Returns short URL click counts.</summary>
            [Google.Apis.Util.StringValueAttribute("FULL")]
            FULL,
        }
        
        public class GetRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Urlshortener.v1.Data.Url> {
            
            private Projection? projection;
            
            private string shortUrl;
            
            public GetRequest(Google.Apis.Discovery.IRequestProvider service, string shortUrl) : 
                    base(service) {
                this.shortUrl = shortUrl;
            }
            
            /// <summary>Additional information to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection")]
            public virtual Projection? Projection {
                get {
                    return this.projection;
                }
                set {
                    this.projection = value;
                }
            }
            
            /// <summary>The short URL, including the protocol.</summary>
            [Google.Apis.Util.RequestParameterAttribute("shortUrl")]
            public virtual string ShortUrl {
                get {
                    return this.shortUrl;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "url";
                }
            }
            
            protected override string MethodName {
                get {
                    return "get";
                }
            }
        }
        
        public class InsertRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Urlshortener.v1.Data.Url> {
            
            private Google.Apis.Urlshortener.v1.Data.Url bodyValue;
            
            public InsertRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Urlshortener.v1.Data.Url body) : 
                    base(service) {
                this.Body = body;
            }
            
            /// <summary>Gets/Sets the Body of this Request.</summary>
            public virtual Google.Apis.Urlshortener.v1.Data.Url Body {
                get {
                    return this.bodyValue;
                }
                set {
                    this.bodyValue = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "url";
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
        
        public class ListRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Urlshortener.v1.Data.UrlHistory> {
            
            private ProjectionEnum? projection;
            
            private string startToken;
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service) : 
                    base(service) {
            }
            
            /// <summary>Additional information to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection")]
            public virtual ProjectionEnum? Projection {
                get {
                    return this.projection;
                }
                set {
                    this.projection = value;
                }
            }
            
            /// <summary>Token for requesting successive pages of results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("start-token")]
            public virtual string StartToken {
                get {
                    return this.startToken;
                }
                set {
                    this.startToken = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "url";
                }
            }
            
            protected override string MethodName {
                get {
                    return "list";
                }
            }
        }
    }
    
    public partial class UrlshortenerService {
        
        private const string Resource = "";
        
        private UrlResource url;
        
        private Google.Apis.Discovery.IRequestProvider service {
            get {
                return this;
            }
        }
        
        public virtual UrlResource Url {
            get {
                return this.url;
            }
        }
    }
}
