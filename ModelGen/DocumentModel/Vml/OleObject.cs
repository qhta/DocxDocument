namespace DocumentModel.Vml;


/// <summary>
///   Embedded OLE Object.
/// </summary>
public partial class OleObject
{
  
  /// <summary>
  ///   OLE Object Application
  /// </summary>
  public String? ProgId { get; set; }
  
  
  /// <summary>
  ///   OLE Object Shape
  /// </summary>
  public String? ShapeId { get; set; }
  
  
  /// <summary>
  ///   OLE Object Unique ID
  /// </summary>
  public String? ObjectId { get; set; }
  
  
  /// <summary>
  ///   Relationship
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Embedded Object Alternate Image Request.
  /// </summary>
  public DMVML.LinkType? LinkType { get; set; }
  
  
  /// <summary>
  ///   Embedded Object Cannot Be Refreshed.
  /// </summary>
  public DMVML.LockedField? LockedField { get; set; }
  
  
  /// <summary>
  ///   WordprocessingML Field Switches.
  /// </summary>
  public DMVML.FieldCodes? FieldCodes { get; set; }
  
}
