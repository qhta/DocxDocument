namespace DocumentModel.Packaging;

/// <summary>
/// Defines the LegacyDiagramTextPart
/// </summary>
public class LegacyDiagramTextPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, LegacyDiagramTextPart
{
  public new DocumentFormat.OpenXml.Packaging.LegacyDiagramTextPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.LegacyDiagramTextPart?)_OpenXmlElement;
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
