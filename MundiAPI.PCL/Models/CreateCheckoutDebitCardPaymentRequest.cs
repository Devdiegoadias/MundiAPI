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
    public class CreateCheckoutDebitCardPaymentRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string statementDescriptor;
        private Models.CreatePaymentAuthenticationRequest authentication;

        /// <summary>
        /// Card invoice text descriptor
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor 
        { 
            get 
            {
                return this.statementDescriptor; 
            } 
            set 
            {
                this.statementDescriptor = value;
                onPropertyChanged("StatementDescriptor");
            }
        }

        /// <summary>
        /// Creates payment authentication
        /// </summary>
        [JsonProperty("authentication")]
        public Models.CreatePaymentAuthenticationRequest Authentication 
        { 
            get 
            {
                return this.authentication; 
            } 
            set 
            {
                this.authentication = value;
                onPropertyChanged("Authentication");
            }
        }
    }
} 