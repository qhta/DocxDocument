namespace DocumentModel.Math;


/// <summary>
///   Superscript Properties.
/// </summary>
public partial class SuperscriptProperties: ModelElement<DXM.SuperscriptProperties>
{
  public SuperscriptProperties(): base(){ }
  
  public SuperscriptProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SuperscriptProperties(DXM.SuperscriptProperties openXmlElement): base(openXmlElement) { }
  
  
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
