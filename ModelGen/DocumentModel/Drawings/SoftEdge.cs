namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a soft edge effect. The edges of the shape are blurred, while the fill is not affected.
/// </summary>
public partial class SoftEdge
{
  
  /// <summary>
  ///   Specifies the radius of blur to apply to the edges.
  /// </summary>
  public Int64? Radius { get; set; }
  
}
