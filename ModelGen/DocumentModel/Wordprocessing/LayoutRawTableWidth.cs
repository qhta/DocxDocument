namespace DocumentModel.Wordprocessing;


/// <summary>
///   Ignore Space Before Table When Deciding If Table Should Wrap Floating Object.
/// </summary>
public partial class LayoutRawTableWidth: ModelElement<DXW.LayoutRawTableWidth>
{
  public LayoutRawTableWidth(): base(){ }
  
  public LayoutRawTableWidth(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LayoutRawTableWidth(DXW.LayoutRawTableWidth openXmlElement): base(openXmlElement) { }
  
}
