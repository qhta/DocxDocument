namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of a shape or range of shapes.
/// </summary>
public enum MsoShapeType
{
  /// <summary>
  /// Specifies the type of a shape or range of shapes.
  /// </summary>
  msoShapeTypeMixed = -2,
  /// <summary>
  /// AutoShape.
  /// </summary>
  msoAutoShape = 1,
  /// <summary>
  /// Callout.
  /// </summary>
  msoCallout = 2,
  /// <summary>
  /// Chart.
  /// </summary>
  msoChart = 3,
  /// <summary>
  /// Comment.
  /// </summary>
  msoComment = 4,
  /// <summary>
  /// Freeform.
  /// </summary>
  msoFreeform = 5,
  /// <summary>
  /// Group. msoEmbeddedOLEObject7 Embedded OLE object.
  /// </summary>
  msoGroup = 6,
  /// <summary>
  /// Specifies the type of a shape or range of shapes.
  /// </summary>
  msoEmbeddedOLEObject = 7,
  /// <summary>
  /// Form control.
  /// </summary>
  msoFormControl = 8,
  /// <summary>
  /// Line.
  /// </summary>
  msoLine = 9,
  /// <summary>
  /// Linked OLE object.
  /// </summary>
  msoLinkedOLEObject = 10,
  /// <summary>
  /// Linked picture.
  /// </summary>
  msoLinkedPicture = 11,
  /// <summary>
  /// OLE control object. public enum class MsoShapeType ﾉ Expand table
  /// </summary>
  msoOLEControlObject = 12,
  /// <summary>
  /// Picture.
  /// </summary>
  msoPicture = 13,
  /// <summary>
  /// Placeholder.
  /// </summary>
  msoPlaceholder = 14,
  /// <summary>
  /// Text effect.
  /// </summary>
  msoTextEffect = 15,
  /// <summary>
  /// Media.
  /// </summary>
  msoMedia = 16,
  /// <summary>
  /// Text box.
  /// </summary>
  msoTextBox = 17,
  /// <summary>
  /// Script anchor.
  /// </summary>
  msoScriptAnchor = 18,
  /// <summary>
  /// Table.
  /// </summary>
  msoTable = 19,
  /// <summary>
  /// Canvas.
  /// </summary>
  msoCanvas = 20,
  /// <summary>
  /// Diagram.
  /// </summary>
  msoDiagram = 21,
  /// <summary>
  /// Ink.
  /// </summary>
  msoInk = 22,
  /// <summary>
  /// Ink comment.
  /// </summary>
  msoInkComment = 23,
  /// <summary>
  /// msoSlicer 25
  /// </summary>
  msoSmartArt = 24,
  /// <summary>
  /// msoWebVideo 26 Web video.
  /// </summary>
  msoSlicer = 25,
  /// <summary>
  /// Web video.
  /// </summary>
  msoWebVideo = 26
}
