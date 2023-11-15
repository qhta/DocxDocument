namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the TextData Class.
/// </summary>
public partial class TextData: ModelElement<DXO16DCD.TextData>
{
  public TextData(): base(){ }
  
  public TextData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextData(DXO16DCD.TextData openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDCD16.Formula? Formula
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlFormulaElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlFormulaElement");
  }
  
  [DataMember]
  public DMDCD16.VXsdstring? VXsdstring
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
}
