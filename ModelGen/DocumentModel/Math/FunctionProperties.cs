namespace DocumentModel.Math;


/// <summary>
///   Function Properties.
/// </summary>
public partial class FunctionProperties: ModelElement<DXM.FunctionProperties>
{
  public FunctionProperties(): base(){ }
  
  public FunctionProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FunctionProperties(DXM.FunctionProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  [DataMember]
  public DMM.ControlProperties? ControlProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
