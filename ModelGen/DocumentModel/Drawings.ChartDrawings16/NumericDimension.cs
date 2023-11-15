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
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlFormulaElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlFormulaElement");
  }
  
  [DataMember]
  public DMDCD16.NfFormula? NfFormula
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlFormulaElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlFormulaElement");
  }
  
}
