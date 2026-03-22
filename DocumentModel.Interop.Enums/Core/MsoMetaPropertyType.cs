namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the metadata property type.
/// </summary>
public enum MsoMetaPropertyType
{
  /// <summary>
  /// Represents an unknown value.
  /// </summary>
  msoMetaPropertyTypeUnknown,
  /// <summary>
  /// Represents a Boolean value.
  /// </summary>
  msoMetaPropertyTypeBoolean,
  /// <summary>
  /// Represents a value from one or more choices.
  /// </summary>
  msoMetaPropertyTypeChoice,
  /// <summary>
  /// Represents a calculated value.
  /// </summary>
  msoMetaPropertyTypeCalculated,
  /// <summary>
  /// Represents a computed value.
  /// </summary>
  msoMetaPropertyTypeComputed,
  /// <summary>
  /// Represents a Currency value
  /// </summary>
  msoMetaPropertyTypeCurrency,
  /// <summary>
  /// Represents a DateTime value.
  /// </summary>
  msoMetaPropertyTypeDateTime,
  /// <summary>
  /// Represents a value from two or more choices that is written-in by the user.
  /// </summary>
  msoMetaPropertyTypeFillInChoice,
  /// <summary>
  /// Represents a GUID value.
  /// </summary>
  msoMetaPropertyTypeGuid,
  /// <summary>
  /// Represents an Integer value.
  /// </summary>
  msoMetaPropertyTypeInteger,
  /// <summary>
  /// Represents a value used to lookup another value. public enum class MsoMetaPropertyType ﾉ Expand table
  /// msoMetaPropertyTypeMultiChoiceLookup11 Represents a collection of choices used to lookup another value.
  /// </summary>
  msoMetaPropertyTypeLookup,
  /// <summary>
  /// Specifies the metadata property type.
  /// </summary>
  msoMetaPropertyTypeMultiChoiceLookup,
  /// <summary>
  /// Represents a collection of choices.
  /// </summary>
  msoMetaPropertyTypeMultiChoice,
  /// <summary>
  /// Represents a collection of choices that require the user to write-in a value.
  /// </summary>
  msoMetaPropertyTypeMultiChoiceFillIn,
  /// <summary>
  /// Represents a value of one or more sentences.
  /// </summary>
  msoMetaPropertyTypeNote,
  /// <summary>
  /// Represents a generic number data type.
  /// </summary>
  msoMetaPropertyTypeNumber,
  /// <summary>
  /// Represents a Text value.
  /// </summary>
  msoMetaPropertyTypeText,
  /// <summary>
  /// Represents a URL.
  /// </summary>
  msoMetaPropertyTypeUrl,
  /// <summary>
  /// Represents a category of user.
  /// </summary>
  msoMetaPropertyTypeUser,
  /// <summary>
  /// msoMetaPropertyTypeBusinessData 20 msoMetaPropertyTypeBusinessDataSecondary21
  /// </summary>
  msoMetaPropertyTypeUserMulti,
  /// <summary>
  /// msoMetaPropertyTypeBusinessDataSecondary21
  /// </summary>
  msoMetaPropertyTypeBusinessData,
  /// <summary>
  /// Specifies the metadata property type.
  /// </summary>
  msoMetaPropertyTypeBusinessDataSecondary,
  /// <summary>
  /// Represents the maximum value for a range.
  /// </summary>
  msoMetaPropertyTypeMax
}
