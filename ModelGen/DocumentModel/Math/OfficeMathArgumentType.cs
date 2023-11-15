namespace DocumentModel.Math;


/// <summary>
///   Defines the OfficeMathArgumentType Class.
/// </summary>
public partial class OfficeMathArgumentType: ModelElement<DXM.OfficeMathArgumentType>
{
  public OfficeMathArgumentType(): base(){ }
  
  public OfficeMathArgumentType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public OfficeMathArgumentType(DXM.OfficeMathArgumentType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Argument Properties.
  /// </summary>
  [DataMember]
  public DMM.ArgumentProperties? ArgumentProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
