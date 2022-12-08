namespace DocumentModel.Packaging;

/// <summary>
/// Defines the NamedSheetViewsPart
/// </summary>
public class NamedSheetViewsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, NamedSheetViewsPart
{
  public new DocumentFormat.OpenXml.Packaging.NamedSheetViewsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.NamedSheetViewsPart?)_OpenXmlElement;
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
