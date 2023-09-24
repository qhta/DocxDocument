namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a gradient fill. A gradient fill is a fill that is characterized by a smooth gradual transition from one color to the next.
/// </summary>
public partial class GradientFillProperties
{
  
  /// <summary>
  ///   GradientStopList.
  /// </summary>
  public GradientStopList? GradientStopList { get; set; }
  
  public LinearShadeProperties? LinearShadeProperties { get; set; }
  
  public PathShadeProperties? PathShadeProperties { get; set; }
  
}
