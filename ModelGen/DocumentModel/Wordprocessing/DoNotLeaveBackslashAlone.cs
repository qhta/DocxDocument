namespace DocumentModel.Wordprocessing;


/// <summary>
///   Convert Backslash To Yen Sign When Entered.
/// </summary>
public partial class DoNotLeaveBackslashAlone: ModelElement<DXW.DoNotLeaveBackslashAlone>
{
  public DoNotLeaveBackslashAlone(): base(){ }
  
  public DoNotLeaveBackslashAlone(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotLeaveBackslashAlone(DXW.DoNotLeaveBackslashAlone openXmlElement): base(openXmlElement) { }
  
}
