namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether the contents of this run shall have right-to-left characteristics. Specifically, the following behaviors are applied when this element’s val attribute is true (or an equivalent):
/// </summary>
public partial class RightToLeftText: ModelElement<DXW.RightToLeftText>
{
  public RightToLeftText(): base(){ }
  
  public RightToLeftText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RightToLeftText(DXW.RightToLeftText openXmlElement): base(openXmlElement) { }
  
}
