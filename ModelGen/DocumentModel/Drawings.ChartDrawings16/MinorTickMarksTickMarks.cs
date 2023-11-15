namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the MinorTickMarksTickMarks Class.
/// </summary>
public partial class MinorTickMarksTickMarks: ModelElement<DXO16DCD.MinorTickMarksTickMarks>
{
  public MinorTickMarksTickMarks(): base(){ }
  
  public MinorTickMarksTickMarks(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MinorTickMarksTickMarks(DXO16DCD.MinorTickMarksTickMarks openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
