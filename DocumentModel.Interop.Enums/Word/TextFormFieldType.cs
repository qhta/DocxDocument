namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the text form field type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtextformfieldtype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdTextFormFieldType))]
public enum TextFormFieldType
{
  /// <summary>
  /// Regular text field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTextFormFieldType.wdRegularText))]
  RegularText = 0,
  /// <summary>
  /// Number text field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTextFormFieldType.wdNumberText))]
  NumberText = 1,
  /// <summary>
  /// Date text field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTextFormFieldType.wdDateText))]
  DateText = 2,
  /// <summary>
  /// Current date text field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTextFormFieldType.wdCurrentDateText))]
  CurrentDateText = 3,
  /// <summary>
  /// Current time text field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTextFormFieldType.wdCurrentTimeText))]
  CurrentTimeText = 4,
  /// <summary>
  /// Calculation text field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTextFormFieldType.wdCalculationText))]
  CalculationText = 5
}
