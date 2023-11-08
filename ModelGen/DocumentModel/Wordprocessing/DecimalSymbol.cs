namespace DocumentModel.Wordprocessing;


/// <summary>
///   Radix Point for Field Code Evaluation.
/// </summary>
public partial class DecimalSymbol: ModelElement<DXW.DecimalSymbol>
{
  public DecimalSymbol(): base(){ }
  
  public DecimalSymbol(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DecimalSymbol(DXW.DecimalSymbol openXmlElement): base(openXmlElement) { }
  
}
