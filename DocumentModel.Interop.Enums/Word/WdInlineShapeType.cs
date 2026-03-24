namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifiesa shape type for inlie shapes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdinlineshapetype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdInlineShapeType
{
  /// <summary>
  /// Specifiesa shape type for inlie shapes.
  /// </summary>
  EmbeddedOLEObject = 1,
  /// <summary>
  /// Linked OLE object.
  /// </summary>
  LinkedOLEObject = 2,
  /// <summary>
  /// Picture.
  /// </summary>
  Picture = 3,
  /// <summary>
  /// Linked picture.
  /// </summary>
  LinkedPicture = 4,
  /// <summary>
  /// OLE control object.
  /// </summary>
  OLEControlObject = 5,
  /// <summary>
  /// Horizontal line.
  /// </summary>
  HorizontalLine = 6,
  /// <summary>
  /// Specifiesa shape type for inlie shapes.
  /// </summary>
  PictureHorizontalLine = 7,
  /// <summary>
  /// Specifiesa shape type for inlie shapes.
  /// </summary>
  LinkedPictureHorizontalLine = 8,
  /// <summary>
  /// Picture used as a bullet.
  /// </summary>
  PictureBullet = 9,
  /// <summary>
  /// Script anchor. Refers to anchor location for block of script stored with a document.
  /// </summary>
  ScriptAnchor = 10,
  /// <summary>
  /// Specifiesa shape type for inlie shapes.
  /// </summary>
  OWSAnchor = 11,
  /// <summary>
  /// Specifiesa shape type for inlie shapes.
  /// </summary>
  Chart = 12,
  /// <summary>
  /// Specifiesa shape type for inlie shapes.
  /// </summary>
  Diagram = 13,
  /// <summary>
  /// Specifiesa shape type for inlie shapes.
  /// </summary>
  LockedCanvas = 14,
  /// <summary>
  /// Specifiesa shape type for inlie shapes.
  /// </summary>
  SmartArt = 15,
  /// <summary>
  /// Specifiesa shape type for inlie shapes.
  /// </summary>
  WebVideo = 16
}
