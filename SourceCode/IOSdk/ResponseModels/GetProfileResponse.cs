using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace IOSdk.ResponseModels
{
	///<summary>
	/// Model Class of GetProfileResponse
	///</summary>
    class GetProfileResponse
    {
        [JsonProperty("Identities")]
        public object Identities { get; set; }

        [JsonProperty("ID")]
        public string Id { get; set; }

        [JsonProperty("IsActive")]
        public bool IsActive { get; set; }

        [JsonProperty("IsDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("EmailVerified")]
        public bool EmailVerified { get; set; }

        [JsonProperty("Email")]
        public Email[] Email { get; set; }

        [JsonProperty("NoOfLogins")]
        public long NoOfLogins { get; set; }

        [JsonProperty("Provider")]
        public string Provider { get; set; }

        [JsonProperty("LastPasswordChangeDate")]
        public DateTimeOffset LastPasswordChangeDate { get; set; }

        [JsonProperty("LastPasswordChangeToken")]
        public object LastPasswordChangeToken { get; set; }

        [JsonProperty("FullName")]
        public string FullName { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("Uid")]
        public string Uid { get; set; }

        [JsonProperty("CreatedDate")]
        public DateTimeOffset CreatedDate { get; set; }

        [JsonProperty("ModifiedDate")]
        public DateTimeOffset ModifiedDate { get; set; }

        [JsonProperty("RegistrationProvider")]
        public string RegistrationProvider { get; set; }

        [JsonProperty("ExternalIds")]
        public object ExternalIds { get; set; }

        [JsonProperty("UnverifiedEmail")]
        public object UnverifiedEmail { get; set; }

        [JsonProperty("IsCustomUid")]
        public object IsCustomUid { get; set; }

        [JsonProperty("RegistrationSource")]
        public string RegistrationSource { get; set; }

        [JsonProperty("CustomFields")]
        public object CustomFields { get; set; }

        [JsonProperty("Prefix")]
        public string Prefix { get; set; }

        [JsonProperty("MiddleName")]
        public object MiddleName { get; set; }

        [JsonProperty("Suffix")]
        public string Suffix { get; set; }

        [JsonProperty("NickName")]
        public object NickName { get; set; }

        [JsonProperty("ProfileName")]
        public object ProfileName { get; set; }

        [JsonProperty("BirthDate")]
        public object BirthDate { get; set; }

        [JsonProperty("Gender")]
        public string Gender { get; set; }

        [JsonProperty("Website")]
        public object Website { get; set; }

        [JsonProperty("ThumbnailImageUrl")]
        public object ThumbnailImageUrl { get; set; }

        [JsonProperty("ImageUrl")]
        public object ImageUrl { get; set; }

        [JsonProperty("Favicon")]
        public object Favicon { get; set; }

        [JsonProperty("ProfileUrl")]
        public object ProfileUrl { get; set; }

        [JsonProperty("HomeTown")]
        public object HomeTown { get; set; }

        [JsonProperty("State")]
        public object State { get; set; }

        [JsonProperty("City")]
        public object City { get; set; }

        [JsonProperty("Industry")]
        public object Industry { get; set; }

        [JsonProperty("About")]
        public object About { get; set; }

        [JsonProperty("TimeZone")]
        public object TimeZone { get; set; }

        [JsonProperty("CoverPhoto")]
        public object CoverPhoto { get; set; }

        [JsonProperty("TagLine")]
        public object TagLine { get; set; }

        [JsonProperty("Country")]
        public object Country { get; set; }

        [JsonProperty("LastLoginDate")]
        public DateTimeOffset LastLoginDate { get; set; }
    }
}
