namespace DocumentModel.Wordprocessing;


/// <summary>
///   Don't Justify Lines Ending in Soft Line Break.
/// </summary>
public partial class DoNotExpandShiftReturn: ModelElement<DXW.DoNotExpandShiftReturn>
{
  public DoNotExpandShiftReturn(): base(){ }
  
  public DoNotExpandShiftReturn(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotExpandShiftReturn(DXW.DoNotExpandShiftReturn openXmlElement): base(openXmlElement) { }
  
}
