namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a linear gradient.
/// </summary>
public partial class LinearGradientFill
{
  
  /// <summary>
  ///   Specifies the direction of color change for the gradient. To define this angle, let its value be x measured clockwise. Then ( -sin x, cos x ) is a vector parallel to the line of constant color in the gradient fill.
  /// </summary>
  [SchemaAttr("ang")]
  public Int32? Angle { get; set; }
  
  
  /// <summary>
  ///   Whether the gradient angle scales with the fill region. Mathematically, if this flag is true, then the gradient vector ( cos x , sin x ) is scaled by the width (w) and height (h) of the fill region, so that the vector becomes ( w cos x, h sin x ) (before normalization). Observe that now if the gradient angle is 45 degrees, the gradient vector is ( w, h ), which goes from top-left to bottom-right of the fill region. If this flag is false, the gradient angle is independent of the fill region and is not scaled using the manipulation described above. So a 45-degree gradient angle always give a gradient band whose line of constant color is parallel to the vector (1, -1).
  /// </summary>
  [SchemaAttr("scaled")]
  public Boolean? Scaled { get; set; }
  
}
