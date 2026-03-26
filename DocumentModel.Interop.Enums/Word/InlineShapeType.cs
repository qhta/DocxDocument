namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifiesa shape type for inlie shapes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdinlineshapetype?view=office-pia` for Office interop details.
/// </remarks>
public enum InlineShapeType
{
  /// <summary>
  /// Embedded OLE object.
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
  /// Picture with horizontal line.
  /// </summary>
  PictureHorizontalLine = 7,
  /// <summary>
  /// Linked picture with horizontal line.
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
  /// OWS anchor.
  /// </summary>
  OWSAnchor = 11,
  /// <summary>
  /// Inline chart.
  /// </summary>
  Chart = 12,
  /// <summary>
  /// Inline diagram.
  /// </summary>
  Diagram = 13,
  /// <summary>
  /// Locked inline shape canvas.
  /// </summary>
  LockedCanvas = 14,
  /// <summary>
  /// Smart art.
  /// </summary>
  SmartArt = 15,
  /// <summary>
  /// A picture acting as a poster frame for a web video.
  /// </summary>
  WebVideo = 16
}
