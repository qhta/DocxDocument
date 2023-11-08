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
      var element = _Element?.GetFirstChild<DXO16DCD.Formula>();
      if (element != null)
        return FormulaConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.Formula>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormulaConverter.CreateOpenXmlElement<DXO16DCD.Formula>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.NfFormula? NfFormula
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.NfFormula>();
      if (element != null)
        return NfFormulaConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.NfFormula>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NfFormulaConverter.CreateOpenXmlElement<DXO16DCD.NfFormula>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
