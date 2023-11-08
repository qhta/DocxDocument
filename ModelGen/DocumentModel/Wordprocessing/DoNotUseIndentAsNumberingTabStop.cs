namespace DocumentModel.Wordprocessing;


/// <summary>
///   Ignore Hanging Indent When Creating Tab Stop After Numbering.
/// </summary>
public partial class DoNotUseIndentAsNumberingTabStop: ModelElement<DXW.DoNotUseIndentAsNumberingTabStop>
{
  public DoNotUseIndentAsNumberingTabStop(): base(){ }
  
  public DoNotUseIndentAsNumberingTabStop(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotUseIndentAsNumberingTabStop(DXW.DoNotUseIndentAsNumberingTabStop openXmlElement): base(openXmlElement) { }
  
}
