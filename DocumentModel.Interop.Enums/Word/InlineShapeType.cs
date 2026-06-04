namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifiesa shape type for inlie shapes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdinlineshapetype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdInlineShapeType")]
public enum InlineShapeType
{
  /// <summary>
  /// Embedded OLE object.
  /// </summary>
  [InteropEnumValue("wdInlineShapeEmbeddedOLEObject")]
  EmbeddedOLEObject = 1,
  /// <summary>
  /// Linked OLE object.
  /// </summary>
  [InteropEnumValue("wdInlineShapeLinkedOLEObject")]
  LinkedOLEObject = 2,
  /// <summary>
  /// Picture.
  /// </summary>
  [InteropEnumValue("wdInlineShapePicture")]
  Picture = 3,
  /// <summary>
  /// Linked picture.
  /// </summary>
  [InteropEnumValue("wdInlineShapeLinkedPicture")]
  LinkedPicture = 4,
  /// <summary>
  /// OLE control object.
  /// </summary>
  [InteropEnumValue("wdInlineShapeOLEControlObject")]
  OLEControlObject = 5,
  /// <summary>
  /// Horizontal line.
  /// </summary>
  [InteropEnumValue("wdInlineShapeHorizontalLine")]
  HorizontalLine = 6,
  /// <summary>
  /// Picture with horizontal line.
  /// </summary>
  [InteropEnumValue("wdInlineShapePictureHorizontalLine")]
  PictureHorizontalLine = 7,
  /// <summary>
  /// Linked picture with horizontal line.
  /// </summary>
  [InteropEnumValue("wdInlineShapeLinkedPictureHorizontalLine")]
  LinkedPictureHorizontalLine = 8,
  /// <summary>
  /// Picture used as a bullet.
  /// </summary>
  [InteropEnumValue("wdInlineShapePictureBullet")]
  PictureBullet = 9,
  /// <summary>
  /// Script anchor. Refers to anchor location for block of script stored with a document.
  /// </summary>
  [InteropEnumValue("wdInlineShapeScriptAnchor")]
  ScriptAnchor = 10,
  /// <summary>
  /// OWS anchor.
  /// </summary>
  [InteropEnumValue("wdInlineShapeOWSAnchor")]
  OWSAnchor = 11,
  /// <summary>
  /// Inline chart.
  /// </summary>
  [InteropEnumValue("wdInlineShapeChart")]
  Chart = 12,
  /// <summary>
  /// Inline diagram.
  /// </summary>
  [InteropEnumValue("wdInlineShapeDiagram")]
  Diagram = 13,
  /// <summary>
  /// Locked inline shape canvas.
  /// </summary>
  [InteropEnumValue("wdInlineShapeLockedCanvas")]
  LockedCanvas = 14,
  /// <summary>
  /// Smart art.
  /// </summary>
  [InteropEnumValue("wdInlineShapeSmartArt")]
  SmartArt = 15,
  /// <summary>
  /// A picture acting as a poster frame for a web video.
  /// </summary>
  [InteropEnumValue("wdInlineShapeWebVideo")]
  WebVideo = 16
}
