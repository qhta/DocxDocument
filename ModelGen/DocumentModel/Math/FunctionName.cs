namespace DocumentModel.Math;


/// <summary>
///   Function Name.
/// </summary>
public partial class FunctionName: ModelElement<DXM.FunctionName>
{
  public FunctionName(): base(){ }
  
  public FunctionName(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FunctionName(DXM.FunctionName openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMM.ArgumentProperties? ArgumentProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMM.ControlProperties? ControlProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
