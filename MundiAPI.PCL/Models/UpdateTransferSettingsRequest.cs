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
    public class UpdateTransferSettingsRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string transferEnabled;
        private string transferInterval;
        private string transferDay;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("transfer_enabled")]
        public string TransferEnabled 
        { 
            get 
            {
                return this.transferEnabled; 
            } 
            set 
            {
                this.transferEnabled = value;
                onPropertyChanged("TransferEnabled");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("transfer_interval")]
        public string TransferInterval 
        { 
            get 
            {
                return this.transferInterval; 
            } 
            set 
            {
                this.transferInterval = value;
                onPropertyChanged("TransferInterval");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("transfer_day")]
        public string TransferDay 
        { 
            get 
            {
                return this.transferDay; 
            } 
            set 
            {
                this.transferDay = value;
                onPropertyChanged("TransferDay");
            }
        }
    }
} 