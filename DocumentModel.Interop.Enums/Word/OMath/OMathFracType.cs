namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the type of fraction bar.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathfractype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdOMathFracType")]
public enum OMathFracType
{
  /// <summary>
  /// Normal fraction bar.
  /// </summary>
  [WordInteropEnumValue("wdOMathFracBar")]
  Bar = 0,
  /// <summary>
  /// No fraction bar.
  /// </summary>
  [WordInteropEnumValue("wdOMathFracNoBar")]
  NoBar = 1,
  /// <summary>
  /// Skewed fraction bar.
  /// </summary>
  [WordInteropEnumValue("wdOMathFracSkw")]
  Skewed = 2,
  /// <summary>
  /// Show fraction inline.
  /// </summary>
  [WordInteropEnumValue("wdOMathFracLin")]
  Inline = 3
}
