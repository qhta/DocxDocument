namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlicersPart
/// </summary>
public class SlicersPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, SlicersPart
{
  public new DocumentFormat.OpenXml.Packaging.SlicersPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.SlicersPart?)_OpenXmlElement;
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
