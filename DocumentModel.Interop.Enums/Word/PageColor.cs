namespace DocumentModel.Interop.Word;

/// <summary>
/// Constants that represent background page color in reading mode, returned by and passed to PageColor.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpagecolor?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdPageColor))]
public enum PageColor
{
  /// <summary>
  /// No page color, the default. The page background is rendered in white. Any assigned page background colors are
  /// ignored.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageColor.wdPageColorNone))]
  None = 0,
  /// <summary>
  /// Sepia page color, RGB (112, 66, 20) at 80% transparency. Makes no changes to the contents of the document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageColor.wdPageColorSepia))]
  Sepia = 1,
  /// <summary>
  /// Inverse page color. Renders the document content in a manner that resembles high-contrast black, although not
  /// necessarily exactly so. Some figures are rendered in full color on a black background.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageColor.wdPageColorInverse))]
  Inverse = 2
}
