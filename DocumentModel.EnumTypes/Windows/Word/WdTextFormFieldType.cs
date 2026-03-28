namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the text form field type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtextformfieldtype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdTextFormFieldType
{
  /// <summary>
  /// Regular text field.
  /// </summary>
  RegularText = 0,
  /// <summary>
  /// Number text field.
  /// </summary>
  NumberText = 1,
  /// <summary>
  /// Date text field.
  /// </summary>
  DateText = 2,
  /// <summary>
  /// Current date text field.
  /// </summary>
  CurrentDateText = 3,
  /// <summary>
  /// Current time text field.
  /// </summary>
  CurrentTimeText = 4,
  /// <summary>
  /// Calculation text field.
  /// </summary>
  CalculationText = 5
}
