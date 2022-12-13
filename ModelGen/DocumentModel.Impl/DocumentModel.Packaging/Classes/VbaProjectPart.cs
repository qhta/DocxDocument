namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VbaProjectPart
/// </summary>
public class VbaProjectPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, VbaProjectPart
{
  public new DocumentFormat.OpenXml.Packaging.VbaProjectPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.VbaProjectPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public VbaProjectPartImpl(): base() {}
  
  public VbaProjectPartImpl(DocumentFormat.OpenXml.Packaging.VbaProjectPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.VbaProjectPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.VbaProjectPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
