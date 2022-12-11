namespace DocumentModel.Packaging;

/// <summary>
/// Defines the UserDefinedTagsPart
/// </summary>
public class UserDefinedTagsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, UserDefinedTagsPart
{
  public new DocumentFormat.OpenXml.Packaging.UserDefinedTagsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.UserDefinedTagsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public UserDefinedTagsPartImpl(): base() {}
  
  public UserDefinedTagsPartImpl(DocumentFormat.OpenXml.Packaging.UserDefinedTagsPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.UserDefinedTagsPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.UserDefinedTagsPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
