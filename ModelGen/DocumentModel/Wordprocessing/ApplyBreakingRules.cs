namespace DocumentModel.Wordprocessing;


/// <summary>
///   Use Legacy Ethiopic and Amharic Line Breaking Rules.
/// </summary>
public partial class ApplyBreakingRules: ModelElement<DXW.ApplyBreakingRules>
{
  public ApplyBreakingRules(): base(){ }
  
  public ApplyBreakingRules(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ApplyBreakingRules(DXW.ApplyBreakingRules openXmlElement): base(openXmlElement) { }
  
}
