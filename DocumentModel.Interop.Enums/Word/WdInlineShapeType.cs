namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifiesa shape type for inlie shapes.
/// </summary>
public enum WdInlineShapeType
{
  /// <summary>
  /// Specifiesa shape type for inlie shapes.
  /// </summary>
  EmbeddedOLEObject = unchecked((int)1),
  /// <summary>
  /// Linked OLE object.
  /// </summary>
  LinkedOLEObject = unchecked((int)2),
  /// <summary>
  /// Picture.
  /// </summary>
  Picture = unchecked((int)3),
  /// <summary>
  /// Linked picture.
  /// </summary>
  LinkedPicture = unchecked((int)4),
  /// <summary>
  /// OLE control object.
  /// </summary>
  OLEControlObject = unchecked((int)5),
  /// <summary>
  /// Horizontal line. wdInlineShapePictureHorizontalLine7 Picture with horizontal line.
  /// wdInlineShapeLinkedPictureHorizontalLine8 Linked picture with horizontal line.
  /// </summary>
  HorizontalLine = unchecked((int)6),
  /// <summary>
  /// Specifiesa shape type for inlie shapes.
  /// </summary>
  PictureHorizontalLine = unchecked((int)7),
  /// <summary>
  /// Specifiesa shape type for inlie shapes.
  /// </summary>
  LinkedPictureHorizontalLine = unchecked((int)8),
  /// <summary>
  /// Picture used as a bullet.
  /// </summary>
  PictureBullet = unchecked((int)9),
  /// <summary>
  /// Script anchor. Refers to anchor location for block of script stored with a document.
  /// [System.Runtime.InteropServices.Guid("EEEC37A7-495B-30F5-8404-37644FC0358F")] public enum WdInlineShapeType ﾉ
  /// Expand table
  /// </summary>
  ScriptAnchor = unchecked((int)10),
  /// <summary>
  /// OWS anchor.
  /// </summary>
  OWSAnchor = unchecked((int)11),
  /// <summary>
  /// Inline chart.
  /// </summary>
  Chart = unchecked((int)12),
  /// <summary>
  /// Inline diagram.
  /// </summary>
  Diagram = unchecked((int)13),
  /// <summary>
  /// Locked inline shape canvas.
  /// </summary>
  LockedCanvas = unchecked((int)14),
  /// <summary>
  /// Smart art.
  /// </summary>
  SmartArt = unchecked((int)15),
  /// <summary>
  /// A picture acting as a poster frame for a web video.
  /// </summary>
  WebVideo = unchecked((int)16)
}
