// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Apple
    /// </summary>
    public partial class Apple : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Apple" /> class.
        /// </summary>
        /// <param name="cultivar">cultivar</param>
        /// <param name="origin">origin</param>
        [JsonConstructor]
        public Apple(string cultivar, string origin)
        {
            Cultivar = cultivar;
            Origin = origin;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Cultivar
        /// </summary>
        [JsonPropertyName("cultivar")]
        public string Cultivar { get; set; }

        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [JsonPropertyName("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Apple {\n");
            sb.Append("  Cultivar: ").Append(Cultivar).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if (this.Cultivar != null) {
            }

            if (this.Origin != null) {
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Apple" />
    /// </summary>
    public class AppleJsonConverter : JsonConverter<Apple>
    {
        /// <summary>
        /// Deserializes json to <see cref="Apple" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Apple Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string? cultivar = default;
            string? origin = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        case "cultivar":
                            cultivar = utf8JsonReader.GetString();
                            break;
                        case "origin":
                            origin = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (cultivar == null)
                throw new ArgumentNullException(nameof(cultivar), "Property is required for class Apple.");

            if (origin == null)
                throw new ArgumentNullException(nameof(origin), "Property is required for class Apple.");

            return new Apple(cultivar, origin);
        }

        /// <summary>
        /// Serializes a <see cref="Apple" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="apple"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Apple apple, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, apple, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Apple" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="apple"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, Apple apple, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteString("cultivar", apple.Cultivar);
            writer.WriteString("origin", apple.Origin);
        }
    }
}
