namespace DocumentModel.Word10;


/// <summary>
///   This element specifies a gradient fill. A gradient fill is a fill that is characterized by a smooth gradual transition from one color to the next.
/// </summary>
public partial class GradientFillProperties
{
  
  /// <summary>
  ///   GradientStopList.
  /// </summary>
  public DMW10.GradientStopList? GradientStopList { get; set; }
  
  public DMW10.LinearShadeProperties? LinearShadeProperties { get; set; }
  
  public DMW10.PathShadeProperties? PathShadeProperties { get; set; }
  
}
