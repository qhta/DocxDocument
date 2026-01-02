using DocumentModel.Wordprocessing;
namespace DocumentModel.Vml;

/// <summary>
///   Embedded OLE Object.
/// </summary>
public class OleObject: ModelElement, IEmbeddedObjectContent
{
  /// <summary>
  ///   OLE Object Type
  /// </summary>
  public OleKind? Type { get; set; }
  /// <summary>
  ///   OLE Object Application
  /// </summary>
  public string? ProgId { get; set; }
  /// <summary>
  ///   OLE Object Shape
  /// </summary>
  public string? ShapeId { get; set; }
  /// <summary>
  ///   OLE Object Representation
  /// </summary>
  public OleDrawAspectKind? DrawAspect { get; set; }
  /// <summary>
  ///   OLE Object Unique ID
  /// </summary>
  public string? ObjectId { get; set; }
  /// <summary>
  ///   Relationship
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   OLE Update Mode
  /// </summary>
  public OleUpdateMode? UpdateMode { get; set; }
  /// <summary>
  ///   Embedded Object Alternate Image Request.
  /// </summary>
  public string? LinkType { get; set; }
  /// <summary>
  ///   Embedded Object Cannot Be Refreshed.
  /// </summary>
  public string? LockedField { get; set; }
  /// <summary>
  ///   WordprocessingML Field Switches.
  /// </summary>
  public string? FieldCodes { get; set; }
}