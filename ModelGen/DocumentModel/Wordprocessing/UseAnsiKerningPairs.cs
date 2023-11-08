namespace DocumentModel.Wordprocessing;


/// <summary>
///   Use ANSI Kerning Pairs from Fonts.
/// </summary>
public partial class UseAnsiKerningPairs: ModelElement<DXW.UseAnsiKerningPairs>
{
  public UseAnsiKerningPairs(): base(){ }
  
  public UseAnsiKerningPairs(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UseAnsiKerningPairs(DXW.UseAnsiKerningPairs openXmlElement): base(openXmlElement) { }
  
}
