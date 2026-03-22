namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifiesa shape type for inlie shapes.
/// </summary>
public enum WdInlineShapeType
{
  /// <summary>
  /// Specifiesa shape type for inlie shapes.
  /// </summary>
  wdInlineShapeEmbeddedOLEObject = unchecked((int)1),
  /// <summary>
  /// Linked OLE object.
  /// </summary>
  wdInlineShapeLinkedOLEObject = unchecked((int)2),
  /// <summary>
  /// Picture.
  /// </summary>
  wdInlineShapePicture = unchecked((int)3),
  /// <summary>
  /// Linked picture.
  /// </summary>
  wdInlineShapeLinkedPicture = unchecked((int)4),
  /// <summary>
  /// OLE control object.
  /// </summary>
  wdInlineShapeOLEControlObject = unchecked((int)5),
  /// <summary>
  /// Horizontal line. wdInlineShapePictureHorizontalLine7 Picture with horizontal line.
  /// wdInlineShapeLinkedPictureHorizontalLine8 Linked picture with horizontal line.
  /// </summary>
  wdInlineShapeHorizontalLine = unchecked((int)6),
  /// <summary>
  /// Specifiesa shape type for inlie shapes.
  /// </summary>
  wdInlineShapePictureHorizontalLine = unchecked((int)7),
  /// <summary>
  /// Specifiesa shape type for inlie shapes.
  /// </summary>
  wdInlineShapeLinkedPictureHorizontalLine = unchecked((int)8),
  /// <summary>
  /// Picture used as a bullet.
  /// </summary>
  wdInlineShapePictureBullet = unchecked((int)9),
  /// <summary>
  /// Script anchor. Refers to anchor location for block of script stored with a document.
  /// [System.Runtime.InteropServices.Guid("EEEC37A7-495B-30F5-8404-37644FC0358F")] public enum WdInlineShapeType ﾉ
  /// Expand table
  /// </summary>
  wdInlineShapeScriptAnchor = unchecked((int)10),
  /// <summary>
  /// OWS anchor.
  /// </summary>
  wdInlineShapeOWSAnchor = unchecked((int)11),
  /// <summary>
  /// Inline chart.
  /// </summary>
  wdInlineShapeChart = unchecked((int)12),
  /// <summary>
  /// Inline diagram.
  /// </summary>
  wdInlineShapeDiagram = unchecked((int)13),
  /// <summary>
  /// Locked inline shape canvas.
  /// </summary>
  wdInlineShapeLockedCanvas = unchecked((int)14),
  /// <summary>
  /// Smart art.
  /// </summary>
  wdInlineShapeSmartArt = unchecked((int)15),
  /// <summary>
  /// A picture acting as a poster frame for a web video.
  /// </summary>
  wdInlineShapeWebVideo = unchecked((int)16)
}
