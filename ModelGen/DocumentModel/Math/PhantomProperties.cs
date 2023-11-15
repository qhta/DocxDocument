namespace DocumentModel.Math;


/// <summary>
///   Phantom Properties.
/// </summary>
public partial class PhantomProperties: ModelElement<DXM.PhantomProperties>
{
  public PhantomProperties(): base(){ }
  
  public PhantomProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PhantomProperties(DXM.PhantomProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Phantom Show.
  /// </summary>
  [DataMember]
  public DMM.ShowPhantom? ShowPhantom
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
  }
  
  
  /// <summary>
  ///   Phantom Zero Width.
  /// </summary>
  [DataMember]
  public DMM.ZeroWidth? ZeroWidth
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
  }
  
  
  /// <summary>
  ///   Phantom Zero Ascent.
  /// </summary>
  [DataMember]
  public DMM.ZeroAscent? ZeroAscent
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
  }
  
  
  /// <summary>
  ///   Phantom Zero Descent.
  /// </summary>
  [DataMember]
  public DMM.ZeroDescent? ZeroDescent
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
  }
  
  
  /// <summary>
  ///   Transparent (Phantom).
  /// </summary>
  [DataMember]
  public DMM.Transparent? Transparent
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
