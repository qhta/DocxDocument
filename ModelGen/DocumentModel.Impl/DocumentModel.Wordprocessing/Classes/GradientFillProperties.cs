namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the GradientFillProperties Class.
/// </summary>
public class GradientFillPropertiesImpl: ModelElementImpl, GradientFillProperties
{
  public DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
