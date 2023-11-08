namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Total Number of Paragraphs.
/// </summary>
public partial class Paragraphs: ModelElement<DXEP.Paragraphs>
{
  public Paragraphs(): base(){ }
  
  public Paragraphs(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Paragraphs(DXEP.Paragraphs openXmlElement): base(openXmlElement) { }
  
}
