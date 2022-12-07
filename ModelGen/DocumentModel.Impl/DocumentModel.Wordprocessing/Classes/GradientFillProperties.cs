namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the GradientFillProperties Class.
/// </summary>
public class GradientFillPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties>, GradientFillProperties
{
  /// <summary>
  /// GradientStopList.
  /// </summary>
  public GradientStopList? GradientStopList
  {
    get;
    set;
  }
  
  public LinearShadeProperties? LinearShadeProperties
  {
    get;
    set;
  }
  
  public PathShadeProperties? PathShadeProperties
  {
    get;
    set;
  }
  
}
