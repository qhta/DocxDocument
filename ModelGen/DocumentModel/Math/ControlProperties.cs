namespace DocumentModel.Math;


/// <summary>
///   Control Properties.
/// </summary>
public partial class ControlProperties: ModelElement<DXM.ControlProperties>
{
  public ControlProperties(): base(){ }
  
  public ControlProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ControlProperties(DXM.ControlProperties openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.RunProperties? RunProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMW.InsertedMathControl? InsertedMathControl
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMW.DeletedMathControl? DeletedMathControl
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMW.MoveFromMathControl? MoveFromMathControl
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.MathControlMoveType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.MathControlMoveType");
  }
  
  [DataMember]
  public DMW.MoveToMathControl? MoveToMathControl
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.MathControlMoveType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.MathControlMoveType");
  }
  
}
