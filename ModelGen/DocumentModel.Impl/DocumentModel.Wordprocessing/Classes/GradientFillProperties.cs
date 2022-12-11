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
  
  public GradientFillPropertiesImpl(): base() {}
  
  public GradientFillPropertiesImpl(DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// GradientStopList.
  /// </summary>
  public GradientStopList? GradientStopList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public LinearShadeProperties? LinearShadeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public PathShadeProperties? PathShadeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
