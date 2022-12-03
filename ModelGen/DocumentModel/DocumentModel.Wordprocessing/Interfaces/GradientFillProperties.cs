namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the GradientFillProperties Class.
/// </summary>
public interface GradientFillProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// GradientStopList.
  /// </summary>
  public GradientStopList? GradientStopList { get ; set; }
  
  public LinearShadeProperties? LinearShadeProperties { get ; set; }
  
  public PathShadeProperties? PathShadeProperties { get ; set; }
  
}
