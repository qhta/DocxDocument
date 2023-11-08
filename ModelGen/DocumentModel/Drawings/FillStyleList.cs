namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a set of three fill styles that are used within a theme.  The three fill styles are arranged in order from subtle to moderate to intense.
/// </summary>
public partial class FillStyleList: ModelElement<DXD.FillStyleList>
{
  public FillStyleList(): base(){ }
  
  public FillStyleList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FillStyleList(DXD.FillStyleList openXmlElement): base(openXmlElement) { }
  
}
