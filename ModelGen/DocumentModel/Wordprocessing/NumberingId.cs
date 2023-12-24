namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Definition Instance Reference.
/// </summary>
public partial class NumberingId: ModelElement<DXW.NumberingId>
{
  public NumberingId(): base(){ }
  
  public NumberingId(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberingId(DXW.NumberingId openXmlElement): base(openXmlElement) { }
  
}
