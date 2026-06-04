namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the metadata property type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msometapropertytype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoMetaPropertyType")]
public enum MetaPropertyType
{
  /// <summary>
  /// Represents an unknown value.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeUnknown")]
  Unknown,
  /// <summary>
  /// Represents a Boolean value.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeBoolean")]
  Boolean,
  /// <summary>
  /// Represents a value from one or more choices.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeChoice")]
  Choice,
  /// <summary>
  /// Represents a calculated value.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeCalculated")]
  Calculated,
  /// <summary>
  /// Represents a computed value.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeComputed")]
  Computed,
  /// <summary>
  /// Represents a Currency value
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeCurrency")]
  Currency,
  /// <summary>
  /// Represents a DateTime value.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeDateTime")]
  DateTime,
  /// <summary>
  /// Represents a value from two or more choices that is written-in by the user.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeFillInChoice")]
  FillInChoice,
  /// <summary>
  /// Represents a GUID value.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeGuid")]
  Guid,
  /// <summary>
  /// Represents an Integer value.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeInteger")]
  Integer,
  /// <summary>
  /// Represents a value used to lookup another value.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeLookup")]
  Lookup,
  /// <summary>
  /// Represents a collection of choices used to lookup another value.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeMultiChoiceLookup")]
  MultiChoiceLookup,
  /// <summary>
  /// Represents a collection of choices.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeMultiChoice")]
  MultiChoice,
  /// <summary>
  /// Represents a collection of choices that require the user to write-in a value.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeMultiChoiceFillIn")]
  MultiChoiceFillIn,
  /// <summary>
  /// Represents a value of one or more sentences.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeNote")]
  Note,
  /// <summary>
  /// Represents a generic number data type.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeNumber")]
  Number,
  /// <summary>
  /// Represents a Text value.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeText")]
  Text,
  /// <summary>
  /// Represents a URL.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeUrl")]
  Url,
  /// <summary>
  /// Represents a category of user.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeUser")]
  User,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeUserMulti")]
  UserMulti,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeBusinessData")]
  BusinessData,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeBusinessDataSecondary")]
  BusinessDataSecondary,
  /// <summary>
  /// Represents the maximum value for a range.
  /// </summary>
  [OfficeInteropEnumValue("msoMetaPropertyTypeMax")]
  Max
}
