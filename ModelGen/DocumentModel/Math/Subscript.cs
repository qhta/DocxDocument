namespace DocumentModel.Math;


/// <summary>
///   Subscript Function.
/// </summary>
public partial class Subscript: ModelElement<DXM.Subscript>
{
  public Subscript(): base(){ }
  
  public Subscript(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Subscript(DXM.Subscript openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Subscript Properties.
  /// </summary>
  [DataMember]
  public DMM.SubscriptProperties? SubscriptProperties
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
  
  
  /// <summary>
  ///   Subscript (Subscript function).
  /// </summary>
  [DataMember]
  public DMM.SubArgument? SubArgument
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
  }
  
}
