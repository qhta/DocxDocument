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
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
