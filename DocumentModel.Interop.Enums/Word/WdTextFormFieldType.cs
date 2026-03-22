namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the text form field type.
/// </summary>
public enum WdTextFormFieldType
{
  /// <summary>
  /// Regular text field.
  /// </summary>
  wdRegularText = unchecked((int)0),
  /// <summary>
  /// Number text field.
  /// </summary>
  wdNumberText = unchecked((int)1),
  /// <summary>
  /// Date text field.
  /// </summary>
  wdDateText = unchecked((int)2),
  /// <summary>
  /// Current date text field.
  /// </summary>
  wdCurrentDateText = unchecked((int)3),
  /// <summary>
  /// Current time text field.
  /// </summary>
  wdCurrentTimeText = unchecked((int)4),
  /// <summary>
  /// Calculation text field.
  /// </summary>
  wdCalculationText = unchecked((int)5)
}
