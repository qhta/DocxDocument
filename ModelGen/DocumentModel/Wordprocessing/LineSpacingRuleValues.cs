namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the LineSpacingRuleValues enumeration.
/// </summary>
public partial class LineSpacingRuleValues: ModelElement<DXW.LineSpacingRuleValues>
{
  public LineSpacingRuleValues(): base(){ }
  
  public LineSpacingRuleValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineSpacingRuleValues(DXW.LineSpacingRuleValues openXmlElement): base(openXmlElement) { }
  
}
