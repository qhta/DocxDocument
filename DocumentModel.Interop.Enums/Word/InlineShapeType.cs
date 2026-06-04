namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifiesa shape type for inlie shapes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdinlineshapetype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdInlineShapeType))]
public enum InlineShapeType
{
  /// <summary>
  /// Embedded OLE object.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInlineShapeType.wdInlineShapeEmbeddedOLEObject))]
  EmbeddedOLEObject = 1,
  /// <summary>
  /// Linked OLE object.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInlineShapeType.wdInlineShapeLinkedOLEObject))]
  LinkedOLEObject = 2,
  /// <summary>
  /// Picture.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInlineShapeType.wdInlineShapePicture))]
  Picture = 3,
  /// <summary>
  /// Linked picture.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInlineShapeType.wdInlineShapeLinkedPicture))]
  LinkedPicture = 4,
  /// <summary>
  /// OLE control object.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInlineShapeType.wdInlineShapeOLEControlObject))]
  OLEControlObject = 5,
  /// <summary>
  /// Horizontal line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInlineShapeType.wdInlineShapeHorizontalLine))]
  HorizontalLine = 6,
  /// <summary>
  /// Picture with horizontal line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInlineShapeType.wdInlineShapePictureHorizontalLine))]
  PictureHorizontalLine = 7,
  /// <summary>
  /// Linked picture with horizontal line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInlineShapeType.wdInlineShapeLinkedPictureHorizontalLine))]
  LinkedPictureHorizontalLine = 8,
  /// <summary>
  /// Picture used as a bullet.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInlineShapeType.wdInlineShapePictureBullet))]
  PictureBullet = 9,
  /// <summary>
  /// Script anchor. Refers to anchor location for block of script stored with a document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInlineShapeType.wdInlineShapeScriptAnchor))]
  ScriptAnchor = 10,
  /// <summary>
  /// OWS anchor.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInlineShapeType.wdInlineShapeOWSAnchor))]
  OWSAnchor = 11,
  /// <summary>
  /// Inline chart.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInlineShapeType.wdInlineShapeChart))]
  Chart = 12,
  /// <summary>
  /// Inline diagram.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInlineShapeType.wdInlineShapeDiagram))]
  Diagram = 13,
  /// <summary>
  /// Locked inline shape canvas.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInlineShapeType.wdInlineShapeLockedCanvas))]
  LockedCanvas = 14,
  /// <summary>
  /// Smart art.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInlineShapeType.wdInlineShapeSmartArt))]
  SmartArt = 15,
  /// <summary>
  /// A picture acting as a poster frame for a web video.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInlineShapeType.wdInlineShapeWebVideo))]
  WebVideo = 16
}
