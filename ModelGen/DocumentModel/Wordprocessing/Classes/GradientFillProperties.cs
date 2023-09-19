namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a gradient fill. A gradient fill is a fill that is characterized by a smooth gradual transition from one color to the next.
/// </summary>
public partial class GradientFillProperties
{
  
  /// <summary>
  ///   GradientStopList.
  /// </summary>
  [Nullable((Byte)2)]
  public DocumentModel.Wordprocessing.GradientStopList? GradientStopList { get; set; }
  
  public DocumentModel.Wordprocessing.LinearShadeProperties? LinearShadeProperties { get; set; }
  
  public DocumentModel.Wordprocessing.PathShadeProperties? PathShadeProperties { get; set; }
  
}
