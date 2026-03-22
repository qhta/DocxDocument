namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the data type for a document property.
/// </summary>
public enum MsoDocProperties
{
  /// <summary>
  /// Integer value.
  /// </summary>
  msoPropertyTypeNumber = 1,
  /// <summary>
  /// Boolean value.
  /// </summary>
  msoPropertyTypeBoolean,
  /// <summary>
  /// Date value.
  /// </summary>
  msoPropertyTypeDate,
  /// <summary>
  /// String value.
  /// </summary>
  msoPropertyTypeString,
  /// <summary>
  /// Floating point value.
  /// </summary>
  msoPropertyTypeFloat
}
