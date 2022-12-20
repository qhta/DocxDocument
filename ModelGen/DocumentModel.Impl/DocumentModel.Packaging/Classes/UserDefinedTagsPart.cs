namespace DocumentModel.Packaging;

/// <summary>
/// Defines the UserDefinedTagsPart
/// </summary>
public partial class UserDefinedTagsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, UserDefinedTagsPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.UserDefinedTagsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.UserDefinedTagsPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public UserDefinedTagsPartImpl(): base() {}
  
  public UserDefinedTagsPartImpl(DocumentFormat.OpenXml.Packaging.UserDefinedTagsPart openXmlElement): base(openXmlElement)
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
  
}
