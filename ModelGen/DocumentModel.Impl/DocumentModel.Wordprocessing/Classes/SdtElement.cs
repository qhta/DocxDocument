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
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.SdtPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.SdtPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Gets or sets the SdtEndCharProperties.
  /// </summary>
  public virtual DocumentModel.Wordprocessing.SdtEndCharProperties? SdtEndCharProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.SdtEndCharPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.SdtEndCharPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
