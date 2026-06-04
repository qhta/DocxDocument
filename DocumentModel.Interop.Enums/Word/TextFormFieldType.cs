namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the text form field type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtextformfieldtype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdTextFormFieldType")]
public enum TextFormFieldType
{
  /// <summary>
  /// Regular text field.
  /// </summary>
  [WordInteropEnumValue("wdRegularText")]
  RegularText = 0,
  /// <summary>
  /// Number text field.
  /// </summary>
  [WordInteropEnumValue("wdNumberText")]
  NumberText = 1,
  /// <summary>
  /// Date text field.
  /// </summary>
  [WordInteropEnumValue("wdDateText")]
  DateText = 2,
  /// <summary>
  /// Current date text field.
  /// </summary>
  [WordInteropEnumValue("wdCurrentDateText")]
  CurrentDateText = 3,
  /// <summary>
  /// Current time text field.
  /// </summary>
  [WordInteropEnumValue("wdCurrentTimeText")]
  CurrentTimeText = 4,
  /// <summary>
  /// Calculation text field.
  /// </summary>
  [WordInteropEnumValue("wdCalculationText")]
  CalculationText = 5
}
