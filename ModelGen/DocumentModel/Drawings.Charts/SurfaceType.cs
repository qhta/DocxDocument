namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the SurfaceType Class.
/// </summary>
public partial class SurfaceType: ModelElement<DXDC.SurfaceType>
{
  public SurfaceType(): base(){ }
  
  public SurfaceType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SurfaceType(DXDC.SurfaceType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Thickness.
  /// </summary>
  [DataMember]
  public Byte? Thickness
  {
    get => _Element?.GetIntVal<Byte, DXDC.Thickness>();
    set => _ExistingElement.SetIntVal<Byte, DXDC.Thickness>(value);
  }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  [DataMember]
  public DMDC.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Picture Options.
  /// </summary>
  [DataMember]
  public DMDC.PictureOptions? PictureOptions
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
