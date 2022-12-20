namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VbaProjectPart
/// </summary>
public partial class VbaProjectPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, VbaProjectPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.VbaProjectPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.VbaProjectPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public VbaProjectPartImpl(): base() {}
  
  public VbaProjectPartImpl(DocumentFormat.OpenXml.Packaging.VbaProjectPart openXmlElement): base(openXmlElement)
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
  /// Gets the VbaDataPart of the VbaProjectPart
  /// </summary>
  public DocumentModel.Packaging.VbaDataPart? VbaDataPart
  {
    get
    {
      if (OpenXmlElement?.VbaDataPart != null)
        return new DocumentModel.Packaging.VbaDataPartImpl(OpenXmlElement.VbaDataPart);
      return null;
    }
  }
  
}
