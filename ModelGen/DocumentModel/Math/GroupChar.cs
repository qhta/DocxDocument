namespace DocumentModel.Math;


/// <summary>
///   Group-Character Function.
/// </summary>
public partial class GroupChar: ModelElement<DXM.GroupChar>
{
  public GroupChar(): base(){ }
  
  public GroupChar(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupChar(DXM.GroupChar openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Group-Character Properties.
  /// </summary>
  [DataMember]
  public DMM.GroupCharProperties? GroupCharProperties
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
