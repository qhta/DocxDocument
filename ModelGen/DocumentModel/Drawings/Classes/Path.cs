namespace DocumentModel.Drawings;


/// <summary>
///   This element defines that a gradient fill follows a path vs. a linear line.
/// </summary>
public partial class Path
{
  
  /// <summary>
  ///   Path Width
  /// </summary>
  [SchemaAttr("w")]
  public Int64? Width { get; set; }
  
  
  /// <summary>
  ///   Path Height
  /// </summary>
  [SchemaAttr("h")]
  public Int64? Height { get; set; }
  
  
  /// <summary>
  ///   Path Fill
  /// </summary>
  [SchemaAttr("fill")]
  public DocumentModel.Drawings.PathFillModeValues? Fill { get; set; }
  
  
  /// <summary>
  ///   Path Stroke
  /// </summary>
  [SchemaAttr("stroke")]
  public Boolean? Stroke { get; set; }
  
  
  /// <summary>
  ///   3D Extrusion Allowed
  /// </summary>
  [SchemaAttr("extrusionOk")]
  public Boolean? ExtrusionOk { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
