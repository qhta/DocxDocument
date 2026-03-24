namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifiesa shape type for inlie shapes.
/// </summary>
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
  /// Horizontal line. wdInlineShapePictureHorizontalLine7 Picture with horizontal line.
  /// wdInlineShapeLinkedPictureHorizontalLine8 Linked picture with horizontal line.
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
  /// [System.Runtime.InteropServices.Guid("EEEC37A7-495B-30F5-8404-37644FC0358F")] public enum WdInlineShapeType ﾉ
  /// Expand table
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
