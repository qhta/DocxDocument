namespace DocumentModel.Drawings;


/// <summary>
///   This element defines that a gradient fill follows a path vs. a linear line.
/// </summary>
public partial class Path
{
  
  /// <summary>
  ///   Path Width
  /// </summary>
  public Int64? Width { get; set; }
  
  
  /// <summary>
  ///   Path Height
  /// </summary>
  public Int64? Height { get; set; }
  
  
  /// <summary>
  ///   Path Stroke
  /// </summary>
  public Boolean? Stroke { get; set; }
  
  
  /// <summary>
  ///   3D Extrusion Allowed
  /// </summary>
  public Boolean? ExtrusionOk { get; set; }
  
}
