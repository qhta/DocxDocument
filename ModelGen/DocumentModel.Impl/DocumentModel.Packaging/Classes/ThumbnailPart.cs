namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ThumbnailPart
/// </summary>
public class ThumbnailPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ThumbnailPart
{
  public new DocumentFormat.OpenXml.Packaging.ThumbnailPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ThumbnailPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
