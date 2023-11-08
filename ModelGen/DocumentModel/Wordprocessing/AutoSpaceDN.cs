namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether inter-character spacing shall automatically be adjusted between regions of numbers and regions of East Asian text in the current paragraph. These regions shall be determined by the Unicode character values of the text content within the paragraph.
/// </summary>
public partial class AutoSpaceDN: ModelElement<DXW.AutoSpaceDN>
{
  public AutoSpaceDN(): base(){ }
  
  public AutoSpaceDN(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AutoSpaceDN(DXW.AutoSpaceDN openXmlElement): base(openXmlElement) { }
  
}
