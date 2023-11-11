namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the NumericDimension Class.
/// </summary>
public partial class NumericDimension: ModelElement<DXO16DCD.NumericDimension>
{
  public NumericDimension(): base(){ }
  
  public NumericDimension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumericDimension(DXO16DCD.NumericDimension openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDCD16.Formula? Formula
  {
    get
    {
      return _Element?.GetObject<DMDCD16.Formula,DXO16DCD.Formula>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.Formula,DXO16DCD.Formula>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.NfFormula? NfFormula
  {
    get
    {
      return _Element?.GetObject<DMDCD16.NfFormula,DXO16DCD.NfFormula>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.NfFormula,DXO16DCD.NfFormula>(value);
    }
  }
  
}
