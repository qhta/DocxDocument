namespace DocumentModel.Math;


/// <summary>
///   Subscript Properties.
/// </summary>
public partial class SubscriptProperties: ModelElement<DXM.SubscriptProperties>
{
  public SubscriptProperties(): base(){ }
  
  public SubscriptProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SubscriptProperties(DXM.SubscriptProperties openXmlElement): base(openXmlElement) { }
  
  
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
