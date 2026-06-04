namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the type of fraction bar.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathfractype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdOMathFracType")]
public enum OMathFracType
{
  /// <summary>
  /// Normal fraction bar.
  /// </summary>
  [InteropEnumValue("wdOMathFracBar")]
  Bar = 0,
  /// <summary>
  /// No fraction bar.
  /// </summary>
  [InteropEnumValue("wdOMathFracNoBar")]
  NoBar = 1,
  /// <summary>
  /// Skewed fraction bar.
  /// </summary>
  [InteropEnumValue("wdOMathFracSkw")]
  Skewed = 2,
  /// <summary>
  /// Show fraction inline.
  /// </summary>
  [InteropEnumValue("wdOMathFracLin")]
  Inline = 3
}
