namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the data type for a document property.
/// </summary>
public enum MsoPropertyType
{
  /// <summary>
  /// Integer value. The property value is a whole number.
  /// </summary>
  Number = 1,
  /// <summary>
  /// Boolean value. The property value is either true or false.
  /// </summary>
  Boolean = 2,
  /// <summary>
  /// Date value. The property value is a date and time.
  /// </summary>
  Date = 3,
  /// <summary>
  /// String value. The property value is a sequence of characters (text).
  /// </summary>
  String = 4,
  /// <summary>
  /// Floating-point value.
  /// The property value is a number that can contain a fractional part, allowing for more precise representation of numerical data.
  /// </summary>
  Float = 5,
}