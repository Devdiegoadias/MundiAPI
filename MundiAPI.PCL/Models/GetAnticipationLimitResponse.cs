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
    public class GetAnticipationLimitResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int amount;
        private int anticipationFee;

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
        /// Anticipation fee
        /// </summary>
        [JsonProperty("anticipation_fee")]
        public int AnticipationFee 
        { 
            get 
            {
                return this.anticipationFee; 
            } 
            set 
            {
                this.anticipationFee = value;
                onPropertyChanged("AnticipationFee");
            }
        }
    }
} 