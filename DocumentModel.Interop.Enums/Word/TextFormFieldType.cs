namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the text form field type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtextformfieldtype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdTextFormFieldType")]
public enum TextFormFieldType
{
  /// <summary>
  /// Regular text field.
  /// </summary>
  [InteropEnumValue("wdRegularText")]
  RegularText = 0,
  /// <summary>
  /// Number text field.
  /// </summary>
  [InteropEnumValue("wdNumberText")]
  NumberText = 1,
  /// <summary>
  /// Date text field.
  /// </summary>
  [InteropEnumValue("wdDateText")]
  DateText = 2,
  /// <summary>
  /// Current date text field.
  /// </summary>
  [InteropEnumValue("wdCurrentDateText")]
  CurrentDateText = 3,
  /// <summary>
  /// Current time text field.
  /// </summary>
  [InteropEnumValue("wdCurrentTimeText")]
  CurrentTimeText = 4,
  /// <summary>
  /// Calculation text field.
  /// </summary>
  [InteropEnumValue("wdCalculationText")]
  CalculationText = 5
}
