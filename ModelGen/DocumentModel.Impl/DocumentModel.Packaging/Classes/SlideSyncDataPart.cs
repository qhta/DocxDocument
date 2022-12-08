namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlideSyncDataPart
/// </summary>
public class SlideSyncDataPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, SlideSyncDataPart
{
  public new DocumentFormat.OpenXml.Packaging.SlideSyncDataPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.SlideSyncDataPart?)_OpenXmlElement;
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
