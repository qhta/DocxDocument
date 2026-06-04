namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the metadata property type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msometapropertytype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoMetaPropertyType))]
public enum MetaPropertyType
{
  /// <summary>
  /// Represents an unknown value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeUnknown))]
  Unknown,
  /// <summary>
  /// Represents a Boolean value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeBoolean))]
  Boolean,
  /// <summary>
  /// Represents a value from one or more choices.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeChoice))]
  Choice,
  /// <summary>
  /// Represents a calculated value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeCalculated))]
  Calculated,
  /// <summary>
  /// Represents a computed value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeComputed))]
  Computed,
  /// <summary>
  /// Represents a Currency value
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeCurrency))]
  Currency,
  /// <summary>
  /// Represents a DateTime value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeDateTime))]
  DateTime,
  /// <summary>
  /// Represents a value from two or more choices that is written-in by the user.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeFillInChoice))]
  FillInChoice,
  /// <summary>
  /// Represents a GUID value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeGuid))]
  Guid,
  /// <summary>
  /// Represents an Integer value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeInteger))]
  Integer,
  /// <summary>
  /// Represents a value used to lookup another value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeLookup))]
  Lookup,
  /// <summary>
  /// Represents a collection of choices used to lookup another value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeMultiChoiceLookup))]
  MultiChoiceLookup,
  /// <summary>
  /// Represents a collection of choices.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeMultiChoice))]
  MultiChoice,
  /// <summary>
  /// Represents a collection of choices that require the user to write-in a value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeMultiChoiceFillIn))]
  MultiChoiceFillIn,
  /// <summary>
  /// Represents a value of one or more sentences.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeNote))]
  Note,
  /// <summary>
  /// Represents a generic number data type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeNumber))]
  Number,
  /// <summary>
  /// Represents a Text value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeText))]
  Text,
  /// <summary>
  /// Represents a URL.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeUrl))]
  Url,
  /// <summary>
  /// Represents a category of user.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeUser))]
  User,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeUserMulti))]
  UserMulti,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeBusinessData))]
  BusinessData,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeBusinessDataSecondary))]
  BusinessDataSecondary,
  /// <summary>
  /// Represents the maximum value for a range.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeMax))]
  Max
}
