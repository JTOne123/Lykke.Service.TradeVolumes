// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Service.TradeVolumes.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AssetTradeVolumeResponse
    {
        /// <summary>
        /// Initializes a new instance of the AssetTradeVolumeResponse class.
        /// </summary>
        public AssetTradeVolumeResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AssetTradeVolumeResponse class.
        /// </summary>
        public AssetTradeVolumeResponse(double volume, string clientId = default(string), string walletId = default(string), string assetId = default(string))
        {
            ClientId = clientId;
            WalletId = walletId;
            AssetId = assetId;
            Volume = volume;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ClientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "WalletId")]
        public string WalletId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssetId")]
        public string AssetId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Volume")]
        public double Volume { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
