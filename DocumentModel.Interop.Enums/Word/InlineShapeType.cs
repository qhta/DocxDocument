namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifiesa shape type for inlie shapes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdinlineshapetype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdInlineShapeType")]
public enum InlineShapeType
{
  /// <summary>
  /// Embedded OLE object.
  /// </summary>
  [WordInteropEnumValue("wdInlineShapeEmbeddedOLEObject")]
  EmbeddedOLEObject = 1,
  /// <summary>
  /// Linked OLE object.
  /// </summary>
  [WordInteropEnumValue("wdInlineShapeLinkedOLEObject")]
  LinkedOLEObject = 2,
  /// <summary>
  /// Picture.
  /// </summary>
  [WordInteropEnumValue("wdInlineShapePicture")]
  Picture = 3,
  /// <summary>
  /// Linked picture.
  /// </summary>
  [WordInteropEnumValue("wdInlineShapeLinkedPicture")]
  LinkedPicture = 4,
  /// <summary>
  /// OLE control object.
  /// </summary>
  [WordInteropEnumValue("wdInlineShapeOLEControlObject")]
  OLEControlObject = 5,
  /// <summary>
  /// Horizontal line.
  /// </summary>
  [WordInteropEnumValue("wdInlineShapeHorizontalLine")]
  HorizontalLine = 6,
  /// <summary>
  /// Picture with horizontal line.
  /// </summary>
  [WordInteropEnumValue("wdInlineShapePictureHorizontalLine")]
  PictureHorizontalLine = 7,
  /// <summary>
  /// Linked picture with horizontal line.
  /// </summary>
  [WordInteropEnumValue("wdInlineShapeLinkedPictureHorizontalLine")]
  LinkedPictureHorizontalLine = 8,
  /// <summary>
  /// Picture used as a bullet.
  /// </summary>
  [WordInteropEnumValue("wdInlineShapePictureBullet")]
  PictureBullet = 9,
  /// <summary>
  /// Script anchor. Refers to anchor location for block of script stored with a document.
  /// </summary>
  [WordInteropEnumValue("wdInlineShapeScriptAnchor")]
  ScriptAnchor = 10,
  /// <summary>
  /// OWS anchor.
  /// </summary>
  [WordInteropEnumValue("wdInlineShapeOWSAnchor")]
  OWSAnchor = 11,
  /// <summary>
  /// Inline chart.
  /// </summary>
  [WordInteropEnumValue("wdInlineShapeChart")]
  Chart = 12,
  /// <summary>
  /// Inline diagram.
  /// </summary>
  [WordInteropEnumValue("wdInlineShapeDiagram")]
  Diagram = 13,
  /// <summary>
  /// Locked inline shape canvas.
  /// </summary>
  [WordInteropEnumValue("wdInlineShapeLockedCanvas")]
  LockedCanvas = 14,
  /// <summary>
  /// Smart art.
  /// </summary>
  [WordInteropEnumValue("wdInlineShapeSmartArt")]
  SmartArt = 15,
  /// <summary>
  /// A picture acting as a poster frame for a web video.
  /// </summary>
  [WordInteropEnumValue("wdInlineShapeWebVideo")]
  WebVideo = 16
}
