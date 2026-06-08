namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of a shape or range of shapes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoshapetype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoShapeType")]
public enum ShapeType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [InteropEnumValue("msoShapeTypeMixed")]
  ShapeTypeMixed = -2,
  /// <summary>
  /// AutoShape.
  /// </summary>
  [InteropEnumValue("msoAutoShape")]
  AutoShape = 1,
  /// <summary>
  /// Callout.
  /// </summary>
  [InteropEnumValue("msoCallout")]
  Callout = 2,
  /// <summary>
  /// Chart.
  /// </summary>
  [InteropEnumValue("msoChart")]
  Chart = 3,
  /// <summary>
  /// Ink comment.
  /// </summary>
  [InteropEnumValue("msoComment")]
  Comment = 4,
  /// <summary>
  /// Freeform.
  /// </summary>
  [InteropEnumValue("msoFreeform")]
  Freeform = 5,
  /// <summary>
  /// Group.
  /// </summary>
  [InteropEnumValue("msoGroup")]
  Group = 6,
  /// <summary>
  /// Embedded OLE object.
  /// </summary>
  [InteropEnumValue("msoEmbeddedOLEObject")]
  EmbeddedOLEObject = 7,
  /// <summary>
  /// Form control.
  /// </summary>
  [InteropEnumValue("msoFormControl")]
  FormControl = 8,
  /// <summary>
  /// Line.
  /// </summary>
  [InteropEnumValue("msoLine")]
  Line = 9,
  /// <summary>
  /// Linked OLE object.
  /// </summary>
  [InteropEnumValue("msoLinkedOLEObject")]
  LinkedOLEObject = 10,
  /// <summary>
  /// Linked picture.
  /// </summary>
  [InteropEnumValue("msoLinkedPicture")]
  LinkedPicture = 11,
  /// <summary>
  /// OLE control object.
  /// </summary>
  [InteropEnumValue("msoOLEControlObject")]
  OLEControlObject = 12,
  /// <summary>
  /// Picture.
  /// </summary>
  [InteropEnumValue("msoPicture")]
  Picture = 13,
  /// <summary>
  /// Placeholder.
  /// </summary>
  [InteropEnumValue("msoPlaceholder")]
  Placeholder = 14,
  /// <summary>
  /// Text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect")]
  TextEffect = 15,
  /// <summary>
  /// Media.
  /// </summary>
  [InteropEnumValue("msoMedia")]
  Media = 16,
  /// <summary>
  /// Text box.
  /// </summary>
  [InteropEnumValue("msoTextBox")]
  TextBox = 17,
  /// <summary>
  /// Script anchor.
  /// </summary>
  [InteropEnumValue("msoScriptAnchor")]
  ScriptAnchor = 18,
  /// <summary>
  /// Table.
  /// </summary>
  [InteropEnumValue("msoTable")]
  Table = 19,
  /// <summary>
  /// Canvas.
  /// </summary>
  [InteropEnumValue("msoCanvas")]
  Canvas = 20,
  /// <summary>
  /// Diagram.
  /// </summary>
  [InteropEnumValue("msoDiagram")]
  Diagram = 21,
  /// <summary>
  /// Ink comment.
  /// </summary>
  [InteropEnumValue("msoInk")]
  Ink = 22,
  /// <summary>
  /// Ink comment.
  /// </summary>
  [InteropEnumValue("msoInkComment")]
  InkComment = 23,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoSmartArt")]
  SmartArt = 24,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoSlicer")]
  Slicer = 25,
  /// <summary>
  /// Web video.
  /// </summary>
  [InteropEnumValue("msoWebVideo")]
  WebVideo = 26
}
