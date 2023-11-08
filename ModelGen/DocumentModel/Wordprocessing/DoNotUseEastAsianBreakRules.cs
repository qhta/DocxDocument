namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Compress Compressible Characters When Using Document Grid.
/// </summary>
public partial class DoNotUseEastAsianBreakRules: ModelElement<DXW.DoNotUseEastAsianBreakRules>
{
  public DoNotUseEastAsianBreakRules(): base(){ }
  
  public DoNotUseEastAsianBreakRules(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotUseEastAsianBreakRules(DXW.DoNotUseEastAsianBreakRules openXmlElement): base(openXmlElement) { }
  
}
