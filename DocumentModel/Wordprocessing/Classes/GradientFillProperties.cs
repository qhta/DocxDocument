namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the GradientFillProperties Class.
/// </summary>
public partial class GradientFillProperties
{
  /// <summary>
  /// GradientStopList.
  /// </summary>
  public DocumentModel.Wordprocessing.GradientStopList? GradientStopList { get; set; }
  
  public DocumentModel.Wordprocessing.LinearShadeProperties? LinearShadeProperties { get; set; }
  
  public DocumentModel.Wordprocessing.PathShadeProperties? PathShadeProperties { get; set; }
  
}
