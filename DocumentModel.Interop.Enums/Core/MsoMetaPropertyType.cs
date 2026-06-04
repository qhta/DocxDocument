namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the metadata property type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msometapropertytype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoMetaPropertyType")]
public enum MetaPropertyType
{
  /// <summary>
  /// Represents an unknown value.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeUnknown")]
  Unknown,
  /// <summary>
  /// Represents a Boolean value.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeBoolean")]
  Boolean,
  /// <summary>
  /// Represents a value from one or more choices.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeChoice")]
  Choice,
  /// <summary>
  /// Represents a calculated value.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeCalculated")]
  Calculated,
  /// <summary>
  /// Represents a computed value.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeComputed")]
  Computed,
  /// <summary>
  /// Represents a Currency value
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeCurrency")]
  Currency,
  /// <summary>
  /// Represents a DateTime value.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeDateTime")]
  DateTime,
  /// <summary>
  /// Represents a value from two or more choices that is written-in by the user.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeFillInChoice")]
  FillInChoice,
  /// <summary>
  /// Represents a GUID value.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeGuid")]
  Guid,
  /// <summary>
  /// Represents an Integer value.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeInteger")]
  Integer,
  /// <summary>
  /// Represents a value used to lookup another value.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeLookup")]
  Lookup,
  /// <summary>
  /// Represents a collection of choices used to lookup another value.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeMultiChoiceLookup")]
  MultiChoiceLookup,
  /// <summary>
  /// Represents a collection of choices.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeMultiChoice")]
  MultiChoice,
  /// <summary>
  /// Represents a collection of choices that require the user to write-in a value.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeMultiChoiceFillIn")]
  MultiChoiceFillIn,
  /// <summary>
  /// Represents a value of one or more sentences.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeNote")]
  Note,
  /// <summary>
  /// Represents a generic number data type.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeNumber")]
  Number,
  /// <summary>
  /// Represents a Text value.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeText")]
  Text,
  /// <summary>
  /// Represents a URL.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeUrl")]
  Url,
  /// <summary>
  /// Represents a category of user.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeUser")]
  User,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeUserMulti")]
  UserMulti,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeBusinessData")]
  BusinessData,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeBusinessDataSecondary")]
  BusinessDataSecondary,
  /// <summary>
  /// Represents the maximum value for a range.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeMax")]
  Max
}
