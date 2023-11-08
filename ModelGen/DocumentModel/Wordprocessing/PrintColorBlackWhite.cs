namespace DocumentModel.Wordprocessing;


/// <summary>
///   Print Colors as Black And White without Dithering.
/// </summary>
public partial class PrintColorBlackWhite: ModelElement<DXW.PrintColorBlackWhite>
{
  public PrintColorBlackWhite(): base(){ }
  
  public PrintColorBlackWhite(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PrintColorBlackWhite(DXW.PrintColorBlackWhite openXmlElement): base(openXmlElement) { }
  
}
