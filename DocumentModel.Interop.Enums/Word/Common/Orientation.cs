namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a page layout orientation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdorientation?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdOrientation")]
public enum Orientation
{
  /// <summary>
  /// Portrait orientation.
  /// </summary>
  [InteropEnumValue("wdOrientPortrait")]
  Portrait = 0,
  /// <summary>
  /// Landscape orientation.
  /// </summary>
  [InteropEnumValue("wdOrientLandscape")]
  Landscape = 1
}
