namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the StringDimension Class.
/// </summary>
public partial class StringDimension: ModelElement<DXO16DCD.StringDimension>
{
  public StringDimension(): base(){ }
  
  public StringDimension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StringDimension(DXO16DCD.StringDimension openXmlElement): base(openXmlElement) { }
  
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
