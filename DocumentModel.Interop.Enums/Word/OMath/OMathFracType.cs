namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the type of fraction bar.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathfractype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdOMathFracType))]
public enum OMathFracType
{
  /// <summary>
  /// Normal fraction bar.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFracType.wdOMathFracBar))]
  Bar = 0,
  /// <summary>
  /// No fraction bar.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFracType.wdOMathFracNoBar))]
  NoBar = 1,
  /// <summary>
  /// Skewed fraction bar.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFracType.wdOMathFracSkw))]
  Skewed = 2,
  /// <summary>
  /// Show fraction inline.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFracType.wdOMathFracLin))]
  Inline = 3
}
