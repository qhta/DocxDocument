namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a blur effect that is applied to the entire shape, including its fill. All color channels, including alpha, are affected.
/// </summary>
public partial class Blur
{
  
  /// <summary>
  ///   Specifies the radius of blur.
  /// </summary>
  [SchemaAttr("rad")]
  public Int64? Radius { get; set; }
  
  
  /// <summary>
  ///   Specifies whether the bounds of the object should be grown as a result of the blurring. True indicates the bounds are grown while false indicates that they are not.
  /// </summary>
  [SchemaAttr("grow")]
  public Boolean? Grow { get; set; }
  
}
