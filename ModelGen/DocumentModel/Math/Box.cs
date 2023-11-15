namespace DocumentModel.Math;


/// <summary>
///   Box Function.
/// </summary>
public partial class Box: ModelElement<DXM.Box>
{
  public Box(): base(){ }
  
  public Box(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Box(DXM.Box openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Box Properties.
  /// </summary>
  [DataMember]
  public DMM.BoxProperties? BoxProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Base.
  /// </summary>
  [DataMember]
  public DMM.Base? Base
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
  }
  
}
