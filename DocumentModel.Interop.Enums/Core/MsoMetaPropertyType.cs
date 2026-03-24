namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the metadata property type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msometapropertytype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoMetaPropertyType
{
  /// <summary>
  /// Represents an unknown value.
  /// </summary>
  Unknown,
  /// <summary>
  /// Represents a Boolean value.
  /// </summary>
  Boolean,
  /// <summary>
  /// Represents a value from one or more choices.
  /// </summary>
  Choice,
  /// <summary>
  /// Represents a calculated value.
  /// </summary>
  Calculated,
  /// <summary>
  /// Represents a computed value.
  /// </summary>
  Computed,
  /// <summary>
  /// Represents a Currency value
  /// </summary>
  Currency,
  /// <summary>
  /// Represents a DateTime value.
  /// </summary>
  DateTime,
  /// <summary>
  /// Represents a value from two or more choices that is written-in by the user.
  /// </summary>
  FillInChoice,
  /// <summary>
  /// Represents a GUID value.
  /// </summary>
  Guid,
  /// <summary>
  /// Represents an Integer value.
  /// </summary>
  Integer,
  /// <summary>
  /// Represents a value used to lookup another value. public enum class MsoMetaPropertyType ﾉ Expand table
  /// msoMetaPropertyTypeMultiChoiceLookup11 Represents a collection of choices used to lookup another value.
  /// </summary>
  Lookup,
  /// <summary>
  /// Specifies the metadata property type.
  /// </summary>
  MultiChoiceLookup,
  /// <summary>
  /// Represents a collection of choices.
  /// </summary>
  MultiChoice,
  /// <summary>
  /// Represents a collection of choices that require the user to write-in a value.
  /// </summary>
  MultiChoiceFillIn,
  /// <summary>
  /// Represents a value of one or more sentences.
  /// </summary>
  Note,
  /// <summary>
  /// Represents a generic number data type.
  /// </summary>
  Number,
  /// <summary>
  /// Represents a Text value.
  /// </summary>
  Text,
  /// <summary>
  /// Represents a URL.
  /// </summary>
  Url,
  /// <summary>
  /// Represents a category of user.
  /// </summary>
  User,
  /// <summary>
  /// msoMetaPropertyTypeBusinessData 20 msoMetaPropertyTypeBusinessDataSecondary21
  /// </summary>
  UserMulti,
  /// <summary>
  /// msoMetaPropertyTypeBusinessDataSecondary21
  /// </summary>
  BusinessData,
  /// <summary>
  /// Specifies the metadata property type.
  /// </summary>
  BusinessDataSecondary,
  /// <summary>
  /// Represents the maximum value for a range.
  /// </summary>
  Max
}
