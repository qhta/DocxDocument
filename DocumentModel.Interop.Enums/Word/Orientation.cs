namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a page layout orientation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdorientation?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdOrientation))]
public enum Orientation
{
  /// <summary>
  /// Portrait orientation.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOrientation.wdOrientPortrait))]
  Portrait = 0,
  /// <summary>
  /// Landscape orientation.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape))]
  Landscape = 1
}
