namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the MajorTickMarksTickMarks Class.
/// </summary>
public partial class MajorTickMarksTickMarks: ModelElement<DXO16DCD.MajorTickMarksTickMarks>
{
  public MajorTickMarksTickMarks(): base(){ }
  
  public MajorTickMarksTickMarks(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MajorTickMarksTickMarks(DXO16DCD.MajorTickMarksTickMarks openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
