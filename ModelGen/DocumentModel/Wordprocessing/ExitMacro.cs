namespace DocumentModel.Wordprocessing;


/// <summary>
///   Script Function to Execute on Form Field Exit.
/// </summary>
public partial class ExitMacro: ModelElement<DXW.ExitMacro>
{
  public ExitMacro(): base(){ }
  
  public ExitMacro(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ExitMacro(DXW.ExitMacro openXmlElement): base(openXmlElement) { }
  
}
