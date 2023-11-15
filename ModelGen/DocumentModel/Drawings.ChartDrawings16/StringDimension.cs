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
