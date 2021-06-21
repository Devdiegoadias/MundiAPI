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
    public class UpdateAddressRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string number;
        private string complement;
        private Dictionary<string, string> metadata;
        private string line2;

        /// <summary>
        /// Number
        /// </summary>
        [JsonProperty("number")]
        public string Number 
        { 
            get 
            {
                return this.number; 
            } 
            set 
            {
                this.number = value;
                onPropertyChanged("Number");
            }
        }

        /// <summary>
        /// Complement
        /// </summary>
        [JsonProperty("complement")]
        public string Complement 
        { 
            get 
            {
                return this.complement; 
            } 
            set 
            {
                this.complement = value;
                onPropertyChanged("Complement");
            }
        }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata 
        { 
            get 
            {
                return this.metadata; 
            } 
            set 
            {
                this.metadata = value;
                onPropertyChanged("Metadata");
            }
        }

        /// <summary>
        /// Line 2 for address
        /// </summary>
        [JsonProperty("line_2")]
        public string Line2 
        { 
            get 
            {
                return this.line2; 
            } 
            set 
            {
                this.line2 = value;
                onPropertyChanged("Line2");
            }
        }
    }
} 