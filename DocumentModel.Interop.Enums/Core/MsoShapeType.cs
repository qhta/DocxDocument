namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of a shape or range of shapes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoshapetype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoShapeType")]
public enum ShapeType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeTypeMixed")]
  ShapeTypeMixed = -2,
  /// <summary>
  /// AutoShape.
  /// </summary>
  [OfficeInteropEnumValue("msoAutoShape")]
  AutoShape = 1,
  /// <summary>
  /// Callout.
  /// </summary>
  [OfficeInteropEnumValue("msoCallout")]
  Callout = 2,
  /// <summary>
  /// Chart.
  /// </summary>
  [OfficeInteropEnumValue("msoChart")]
  Chart = 3,
  /// <summary>
  /// Ink comment.
  /// </summary>
  [OfficeInteropEnumValue("msoComment")]
  Comment = 4,
  /// <summary>
  /// Freeform.
  /// </summary>
  [OfficeInteropEnumValue("msoFreeform")]
  Freeform = 5,
  /// <summary>
  /// Group.
  /// </summary>
  [OfficeInteropEnumValue("msoGroup")]
  Group = 6,
  /// <summary>
  /// Embedded OLE object.
  /// </summary>
  [OfficeInteropEnumValue("msoEmbeddedOLEObject")]
  EmbeddedOLEObject = 7,
  /// <summary>
  /// Form control.
  /// </summary>
  [OfficeInteropEnumValue("msoFormControl")]
  FormControl = 8,
  /// <summary>
  /// Line.
  /// </summary>
  [OfficeInteropEnumValue("msoLine")]
  Line = 9,
  /// <summary>
  /// Linked OLE object.
  /// </summary>
  [OfficeInteropEnumValue("msoLinkedOLEObject")]
  LinkedOLEObject = 10,
  /// <summary>
  /// Linked picture.
  /// </summary>
  [OfficeInteropEnumValue("msoLinkedPicture")]
  LinkedPicture = 11,
  /// <summary>
  /// OLE control object.
  /// </summary>
  [OfficeInteropEnumValue("msoOLEControlObject")]
  OLEControlObject = 12,
  /// <summary>
  /// Picture.
  /// </summary>
  [OfficeInteropEnumValue("msoPicture")]
  Picture = 13,
  /// <summary>
  /// Placeholder.
  /// </summary>
  [OfficeInteropEnumValue("msoPlaceholder")]
  Placeholder = 14,
  /// <summary>
  /// Text effect.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffect")]
  TextEffect = 15,
  /// <summary>
  /// Media.
  /// </summary>
  [OfficeInteropEnumValue("msoMedia")]
  Media = 16,
  /// <summary>
  /// Text box.
  /// </summary>
  [OfficeInteropEnumValue("msoTextBox")]
  TextBox = 17,
  /// <summary>
  /// Script anchor.
  /// </summary>
  [OfficeInteropEnumValue("msoScriptAnchor")]
  ScriptAnchor = 18,
  /// <summary>
  /// Table.
  /// </summary>
  [OfficeInteropEnumValue("msoTable")]
  Table = 19,
  /// <summary>
  /// Canvas.
  /// </summary>
  [OfficeInteropEnumValue("msoCanvas")]
  Canvas = 20,
  /// <summary>
  /// Diagram.
  /// </summary>
  [OfficeInteropEnumValue("msoDiagram")]
  Diagram = 21,
  /// <summary>
  /// Ink comment.
  /// </summary>
  [OfficeInteropEnumValue("msoInk")]
  Ink = 22,
  /// <summary>
  /// Ink comment.
  /// </summary>
  [OfficeInteropEnumValue("msoInkComment")]
  InkComment = 23,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoSmartArt")]
  SmartArt = 24,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoSlicer")]
  Slicer = 25,
  /// <summary>
  /// Web video.
  /// </summary>
  [OfficeInteropEnumValue("msoWebVideo")]
  WebVideo = 26
}
