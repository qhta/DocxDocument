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
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.NamedSheetViewsPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public override String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.NamedSheetViewsPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
