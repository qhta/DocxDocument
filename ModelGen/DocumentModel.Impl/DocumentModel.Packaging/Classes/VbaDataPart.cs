namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VbaDataPart
/// </summary>
public class VbaDataPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, VbaDataPart
{
  public new DocumentFormat.OpenXml.Packaging.VbaDataPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.VbaDataPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public VbaDataPartImpl(): base() {}
  
  public VbaDataPartImpl(DocumentFormat.OpenXml.Packaging.VbaDataPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.VbaDataPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.VbaDataPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.VbaSuppData? VbaSuppData
  {
    get
    {
      if (OpenXmlElement?.VbaSuppData != null)
        return new DocumentModel.Wordprocessing.VbaSuppDataImpl(OpenXmlElement.VbaSuppData);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Wordprocessing.VbaSuppDataImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.VbaSuppData = valueImpl.OpenXmlElement;
    }
  }
  
}
