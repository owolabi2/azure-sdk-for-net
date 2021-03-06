// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for StorageAccountTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StorageAccountTypes
    {
        [EnumMember(Value = "Standard_LRS")]
        StandardLRS,
        [EnumMember(Value = "Premium_LRS")]
        PremiumLRS
    }
    internal static class StorageAccountTypesEnumExtension
    {
        internal static string ToSerializedValue(this StorageAccountTypes? value)
        {
            return value == null ? null : ((StorageAccountTypes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this StorageAccountTypes value)
        {
            switch( value )
            {
                case StorageAccountTypes.StandardLRS:
                    return "Standard_LRS";
                case StorageAccountTypes.PremiumLRS:
                    return "Premium_LRS";
            }
            return null;
        }

        internal static StorageAccountTypes? ParseStorageAccountTypes(this string value)
        {
            switch( value )
            {
                case "Standard_LRS":
                    return StorageAccountTypes.StandardLRS;
                case "Premium_LRS":
                    return StorageAccountTypes.PremiumLRS;
            }
            return null;
        }
    }
}
