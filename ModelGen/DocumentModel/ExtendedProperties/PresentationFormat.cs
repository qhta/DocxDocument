namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Intended Format of Presentation.
/// </summary>
public partial class PresentationFormat: ModelElement<DXEP.PresentationFormat>
{
  public PresentationFormat(): base(){ }
  
  public PresentationFormat(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PresentationFormat(DXEP.PresentationFormat openXmlElement): base(openXmlElement) { }
  
}
