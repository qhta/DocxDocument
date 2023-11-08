namespace DocumentModel.Wordprocessing;


/// <summary>
///   Print Fractional Character Widths.
/// </summary>
public partial class PrintFractionalCharacterWidth: ModelElement<DXW.PrintFractionalCharacterWidth>
{
  public PrintFractionalCharacterWidth(): base(){ }
  
  public PrintFractionalCharacterWidth(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PrintFractionalCharacterWidth(DXW.PrintFractionalCharacterWidth openXmlElement): base(openXmlElement) { }
  
}
