namespace DocumentModel.Wordprocessing;


/// <summary>
///   Print Two Pages Per Sheet.
/// </summary>
public partial class PrintTwoOnOne: ModelElement<DXW.PrintTwoOnOne>
{
  public PrintTwoOnOne(): base(){ }
  
  public PrintTwoOnOne(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PrintTwoOnOne(DXW.PrintTwoOnOne openXmlElement): base(openXmlElement) { }
  
}
