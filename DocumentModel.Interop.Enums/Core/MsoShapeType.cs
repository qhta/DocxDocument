namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of a shape or range of shapes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoshapetype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoShapeType))]
public enum ShapeType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoShapeTypeMixed))]
  ShapeTypeMixed = -2,
  /// <summary>
  /// AutoShape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoAutoShape))]
  AutoShape = 1,
  /// <summary>
  /// Callout.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoCallout))]
  Callout = 2,
  /// <summary>
  /// Chart.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoChart))]
  Chart = 3,
  /// <summary>
  /// Ink comment.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoComment))]
  Comment = 4,
  /// <summary>
  /// Freeform.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoFreeform))]
  Freeform = 5,
  /// <summary>
  /// Group.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoGroup))]
  Group = 6,
  /// <summary>
  /// Embedded OLE object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoEmbeddedOLEObject))]
  EmbeddedOLEObject = 7,
  /// <summary>
  /// Form control.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoFormControl))]
  FormControl = 8,
  /// <summary>
  /// Line.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoLine))]
  Line = 9,
  /// <summary>
  /// Linked OLE object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoLinkedOLEObject))]
  LinkedOLEObject = 10,
  /// <summary>
  /// Linked picture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoLinkedPicture))]
  LinkedPicture = 11,
  /// <summary>
  /// OLE control object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoOLEControlObject))]
  OLEControlObject = 12,
  /// <summary>
  /// Picture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoPicture))]
  Picture = 13,
  /// <summary>
  /// Placeholder.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoPlaceholder))]
  Placeholder = 14,
  /// <summary>
  /// Text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoTextEffect))]
  TextEffect = 15,
  /// <summary>
  /// Media.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoMedia))]
  Media = 16,
  /// <summary>
  /// Text box.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoTextBox))]
  TextBox = 17,
  /// <summary>
  /// Script anchor.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoScriptAnchor))]
  ScriptAnchor = 18,
  /// <summary>
  /// Table.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoTable))]
  Table = 19,
  /// <summary>
  /// Canvas.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoCanvas))]
  Canvas = 20,
  /// <summary>
  /// Diagram.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoDiagram))]
  Diagram = 21,
  /// <summary>
  /// Ink comment.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoInk))]
  Ink = 22,
  /// <summary>
  /// Ink comment.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoInkComment))]
  InkComment = 23,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoSmartArt))]
  SmartArt = 24,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoSlicer))]
  Slicer = 25,
  /// <summary>
  /// Web video.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoShapeType.msoWebVideo))]
  WebVideo = 26
}
