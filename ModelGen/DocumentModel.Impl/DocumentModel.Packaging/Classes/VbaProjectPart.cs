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
