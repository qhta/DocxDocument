namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether East Asian typography and line-breaking rules shall be applied to text in this paragraph to determine which characters can begin and end each line. This property only applies to Simplified Chinese, Traditional Chinese, and Japanese text in this paragraph.
/// </summary>
public partial class Kinsoku: ModelElement<DXW.Kinsoku>
{
  public Kinsoku(): base(){ }
  
  public Kinsoku(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Kinsoku(DXW.Kinsoku openXmlElement): base(openXmlElement) { }
  
}
