using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the data type of a custom document property in Microsoft Office documents.
/// </summary>
/// <remarks>Use this enumeration to indicate the type of value stored in a custom document property, such as
/// number, boolean, date, string, or floating-point value. This is commonly used when programmatically accessing or
/// setting custom properties in Office automation scenarios.</remarks>
[JsonConverter(typeof(StringEnumConverter))]
public enum MsoDocProperties
{
  /// <summary>
  /// Indicates that the property type is an integer number.
  /// </summary>
  [EnumMember(Value = "Integer")]
  msoPropertyTypeNumber = 1,

  /// <summary>
  /// Specifies that the property type is a Boolean value.
  /// </summary>
  [EnumMember(Value = "Boolean")]
  msoPropertyTypeBoolean,

  /// <summary>
  /// Specifies that the property type is a date-time value.
  /// </summary>
  [EnumMember(Value = "DateTime")]
  msoPropertyTypeDate,

  /// <summary>
  /// Indicates that the property type is a string value.
  /// </summary>
  [EnumMember(Value = "String")]
  msoPropertyTypeString,

  /// <summary>
  /// Specifies that the property type is a floating-point number.
  /// </summary>
  [EnumMember(Value = "Float")]
  msoPropertyTypeFloat
}