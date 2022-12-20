namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VbaDataPart
/// </summary>
public partial class VbaDataPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, VbaDataPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.VbaDataPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.VbaDataPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public VbaDataPartImpl(): base() {}
  
  public VbaDataPartImpl(DocumentFormat.OpenXml.Packaging.VbaDataPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
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
