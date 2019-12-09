using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace IOSdk.ResponseModels
{
	///<summary>
	///Model Class UpdateProfileResponse
	///</summary>
    class UpdateProfileResponse
    {

        [JsonProperty("ID")]
        public string Id { get; set; }

        [JsonProperty("Uid")]
        public string Uid { get; set; }

        [JsonProperty("ExternalIds")]
        public ExternalId[] ExternalIds { get; set; }

        [JsonProperty("IsActive")]
        public bool IsActive { get; set; }

        [JsonProperty("IsDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("UnverifiedEmail")]
        public Email[] UnverifiedEmail { get; set; }

        [JsonProperty("EmailVerified")]
        public bool EmailVerified { get; set; }

        [JsonProperty("Email")]
        public Email[] Email { get; set; }

        [JsonProperty("NoOfLogins")]
        public long NoOfLogins { get; set; }

        [JsonProperty("Provider")]
        public string Provider { get; set; }

        [JsonProperty("RegistrationProvider")]
        public string RegistrationProvider { get; set; }

        [JsonProperty("RegistrationSource")]
        public string RegistrationSource { get; set; }

        [JsonProperty("LastPasswordChangeDate")]
        public DateTimeOffset LastPasswordChangeDate { get; set; }

        [JsonProperty("LastPasswordChangeToken")]
        public Guid LastPasswordChangeToken { get; set; }

        [JsonProperty("LastLoginDate")]
        public DateTimeOffset LastLoginDate { get; set; }

        [JsonProperty("CreatedDate")]
        public DateTimeOffset CreatedDate { get; set; }

        [JsonProperty("ModifiedDate")]
        public DateTimeOffset ModifiedDate { get; set; }

        [JsonProperty("IsCustomUid")]
        public bool IsCustomUid { get; set; }

        [JsonProperty("FullName")]
        public string FullName { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("Prefix")]
        public string Prefix { get; set; }

        [JsonProperty("MiddleName")]
        public string MiddleName { get; set; }

        [JsonProperty("Suffix")]
        public string Suffix { get; set; }

        [JsonProperty("NickName")]
        public string NickName { get; set; }

        [JsonProperty("ProfileName")]
        public string ProfileName { get; set; }

        [JsonProperty("BirthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("Gender")]
        public string Gender { get; set; }

        [JsonProperty("Website")]
        public Uri Website { get; set; }

        [JsonProperty("ThumbnailImageUrl")]
        public Uri ThumbnailImageUrl { get; set; }

        [JsonProperty("ImageUrl")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("Favicon")]
        public Uri Favicon { get; set; }

        [JsonProperty("ProfileUrl")]
        public Uri ProfileUrl { get; set; }

        [JsonProperty("HomeTown")]
        public string HomeTown { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("Industry")]
        public string Industry { get; set; }

        [JsonProperty("About")]
        public string About { get; set; }

        [JsonProperty("TimeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("CoverPhoto")]
        public Uri CoverPhoto { get; set; }

        [JsonProperty("TagLine")]
        public string TagLine { get; set; }

        [JsonProperty("Country")]
        public string Country { get; set; }
    }

    public class Email
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }

    public partial class ExternalId
    {
        [JsonProperty("Source")]
        public string Source { get; set; }

        [JsonProperty("SourceId")]
        public string SourceId { get; set; }
    }

}
