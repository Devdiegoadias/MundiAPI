/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MundiAPI.PCL;
using MundiAPI.PCL.Utilities;


namespace MundiAPI.PCL.Models
{
    public class GetSplitResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string type;
        private int amount;
        private Models.GetRecipientResponse recipient;
        private string gatewayId;
        private Models.GetSplitOptionsResponse options;
        private string id;

        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty("type")]
        public string Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("amount")]
        public int Amount 
        { 
            get 
            {
                return this.amount; 
            } 
            set 
            {
                this.amount = value;
                onPropertyChanged("Amount");
            }
        }

        /// <summary>
        /// Recipient
        /// </summary>
        [JsonProperty("recipient")]
        public Models.GetRecipientResponse Recipient 
        { 
            get 
            {
                return this.recipient; 
            } 
            set 
            {
                this.recipient = value;
                onPropertyChanged("Recipient");
            }
        }

        /// <summary>
        /// The split rule gateway id
        /// </summary>
        [JsonProperty("gateway_id")]
        public string GatewayId 
        { 
            get 
            {
                return this.gatewayId; 
            } 
            set 
            {
                this.gatewayId = value;
                onPropertyChanged("GatewayId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("options")]
        public Models.GetSplitOptionsResponse Options 
        { 
            get 
            {
                return this.options; 
            } 
            set 
            {
                this.options = value;
                onPropertyChanged("Options");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("id")]
        public string Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }
    }
} 