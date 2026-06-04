namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the separator used with data labels.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xldatalabelseparator?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlDataLabelSeparator))]
public enum XlDataLabelSeparator
{
  /// <summary>
  /// Word selects the separator.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDataLabelSeparator.xlDataLabelSeparatorDefault))]
  xlDataLabelSeparatorDefault = 1
}
