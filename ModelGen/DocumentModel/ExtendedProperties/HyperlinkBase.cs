namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Relative Hyperlink Base.
/// </summary>
public partial class HyperlinkBase: ModelElement<DXEP.HyperlinkBase>
{
  public HyperlinkBase(): base(){ }
  
  public HyperlinkBase(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HyperlinkBase(DXEP.HyperlinkBase openXmlElement): base(openXmlElement) { }
  
}
