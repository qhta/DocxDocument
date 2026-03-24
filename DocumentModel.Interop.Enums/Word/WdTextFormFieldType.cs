namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the text form field type.
/// </summary>
public enum WdTextFormFieldType
{
  /// <summary>
  /// Regular text field.
  /// </summary>
  RegularText = unchecked((int)0),
  /// <summary>
  /// Number text field.
  /// </summary>
  NumberText = unchecked((int)1),
  /// <summary>
  /// Date text field.
  /// </summary>
  DateText = unchecked((int)2),
  /// <summary>
  /// Current date text field.
  /// </summary>
  CurrentDateText = unchecked((int)3),
  /// <summary>
  /// Current time text field.
  /// </summary>
  CurrentTimeText = unchecked((int)4),
  /// <summary>
  /// Calculation text field.
  /// </summary>
  CalculationText = unchecked((int)5)
}
