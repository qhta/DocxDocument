namespace DocumentModel.Wordprocessing;


/// <summary>
///   Emulate Word 97 East Asian Line Breaking.
/// </summary>
public partial class UseWord97LineBreakRules: ModelElement<DXW.UseWord97LineBreakRules>
{
  public UseWord97LineBreakRules(): base(){ }
  
  public UseWord97LineBreakRules(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UseWord97LineBreakRules(DXW.UseWord97LineBreakRules openXmlElement): base(openXmlElement) { }
  
}
