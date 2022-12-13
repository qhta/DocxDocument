namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines SdtElement - the base class for the sdt elements.
/// </summary>
public class SdtElementImpl: ModelElementImpl, SdtElement
{
  public DocumentFormat.OpenXml.Wordprocessing.SdtElement? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtElement?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SdtElementImpl(): base() {}
  
  public SdtElementImpl(DocumentFormat.OpenXml.Wordprocessing.SdtElement openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the SdtProperties.
  /// </summary>
  public virtual DocumentModel.Wordprocessing.SdtProperties? SdtProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets or sets the SdtEndCharProperties.
  /// </summary>
  public virtual DocumentModel.Wordprocessing.SdtEndCharProperties? SdtEndCharProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
