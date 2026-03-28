namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the type of a shape or range of shapes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoshapetype?view=office-pia` for Office interop details.
/// </remarks>
public enum ShapeType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  ShapeTypeMixed = -2,
  /// <summary>
  /// AutoShape.
  /// </summary>
  AutoShape = 1,
  /// <summary>
  /// Callout.
  /// </summary>
  Callout = 2,
  /// <summary>
  /// Chart.
  /// </summary>
  Chart = 3,
  /// <summary>
  /// Ink comment.
  /// </summary>
  Comment = 4,
  /// <summary>
  /// Freeform.
  /// </summary>
  Freeform = 5,
  /// <summary>
  /// Group.
  /// </summary>
  Group = 6,
  /// <summary>
  /// Embedded OLE object.
  /// </summary>
  EmbeddedOLEObject = 7,
  /// <summary>
  /// Form control.
  /// </summary>
  FormControl = 8,
  /// <summary>
  /// Line.
  /// </summary>
  Line = 9,
  /// <summary>
  /// Linked OLE object.
  /// </summary>
  LinkedOLEObject = 10,
  /// <summary>
  /// Linked picture.
  /// </summary>
  LinkedPicture = 11,
  /// <summary>
  /// OLE control object.
  /// </summary>
  OLEControlObject = 12,
  /// <summary>
  /// Picture.
  /// </summary>
  Picture = 13,
  /// <summary>
  /// Placeholder.
  /// </summary>
  Placeholder = 14,
  /// <summary>
  /// Text effect.
  /// </summary>
  TextEffect = 15,
  /// <summary>
  /// Media.
  /// </summary>
  Media = 16,
  /// <summary>
  /// Text box.
  /// </summary>
  TextBox = 17,
  /// <summary>
  /// Script anchor.
  /// </summary>
  ScriptAnchor = 18,
  /// <summary>
  /// Table.
  /// </summary>
  Table = 19,
  /// <summary>
  /// Canvas.
  /// </summary>
  Canvas = 20,
  /// <summary>
  /// Diagram.
  /// </summary>
  Diagram = 21,
  /// <summary>
  /// Ink comment.
  /// </summary>
  Ink = 22,
  /// <summary>
  /// Ink comment.
  /// </summary>
  InkComment = 23,
  /// <summary>
  /// No description is available.
  /// </summary>
  SmartArt = 24,
  /// <summary>
  /// No description is available.
  /// </summary>
  Slicer = 25,
  /// <summary>
  /// Web video.
  /// </summary>
  WebVideo = 26
}
