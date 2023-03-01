using DocumentModel.Wordprocessing;

namespace DocumentModel.Vml;

/// <summary>
///   Embedded OLE Object.
/// </summary>
public class OleObject: EmbeddedObjectElement
{
  /// <summary>
  ///   OLE Object Type
  /// </summary>
  public OleKind? Type { get; set; }

  /// <summary>
  ///   OLE Object Application
  /// </summary>
  public String? ProgId { get; set; }

  /// <summary>
  ///   OLE Object Shape
  /// </summary>
  public String? ShapeId { get; set; }

  /// <summary>
  ///   OLE Object Representation
  /// </summary>
  public OleDrawAspectKind? DrawAspect { get; set; }

  /// <summary>
  ///   OLE Object Unique ID
  /// </summary>
  public String? ObjectId { get; set; }

  /// <summary>
  ///   Relationship
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   OLE Update Mode
  /// </summary>
  public OleUpdateMode? UpdateMode { get; set; }

  /// <summary>
  ///   Embedded Object Alternate Image Request.
  /// </summary>
  public String? LinkType { get; set; }

  /// <summary>
  ///   Embedded Object Cannot Be Refreshed.
  /// </summary>
  public String? LockedField { get; set; }

  /// <summary>
  ///   WordprocessingML Field Switches.
  /// </summary>
  public String? FieldCodes { get; set; }
}