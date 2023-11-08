namespace DocumentModel.Wordprocessing;


/// <summary>
///   Emulate Word 2002 Table Style Rules.
/// </summary>
public partial class UseWord2002TableStyleRules: ModelElement<DXW.UseWord2002TableStyleRules>
{
  public UseWord2002TableStyleRules(): base(){ }
  
  public UseWord2002TableStyleRules(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UseWord2002TableStyleRules(DXW.UseWord2002TableStyleRules openXmlElement): base(openXmlElement) { }
  
}
