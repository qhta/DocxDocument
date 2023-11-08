namespace DocumentModel.Wordprocessing;


/// <summary>
///   Different Even/Odd Page Headers and Footers.
/// </summary>
public partial class EvenAndOddHeaders: ModelElement<DXW.EvenAndOddHeaders>
{
  public EvenAndOddHeaders(): base(){ }
  
  public EvenAndOddHeaders(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EvenAndOddHeaders(DXW.EvenAndOddHeaders openXmlElement): base(openXmlElement) { }
  
}
