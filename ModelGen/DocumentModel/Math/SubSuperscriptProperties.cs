namespace DocumentModel.Math;


/// <summary>
///   Sub-Superscript Properties.
/// </summary>
public partial class SubSuperscriptProperties: ModelElement<DXM.SubSuperscriptProperties>
{
  public SubSuperscriptProperties(): base(){ }
  
  public SubSuperscriptProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SubSuperscriptProperties(DXM.SubSuperscriptProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Align Scripts.
  /// </summary>
  [DataMember]
  public DMM.AlignScripts? AlignScripts
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
  }
  
  
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
