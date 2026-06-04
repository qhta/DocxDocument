namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the background type for text in charts.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.xlbackground?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlBackground))]
public enum XlBackground
{
  /// <summary>
  /// Transparent background.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlBackground.xlBackgroundTransparent))]
  Transparent = 2,
  /// <summary>
  /// Opaque background.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlBackground.xlBackgroundOpaque))]
  Opaque = 3,
  /// <summary>
  /// Word controls the background.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlBackground.xlBackgroundAutomatic))]
  Automatic = -4105
}
