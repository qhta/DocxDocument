namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Scaling.
/// </summary>
public partial class Scaling: ModelElement<DXDC.Scaling>
{
  public Scaling(): base(){ }
  
  public Scaling(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Scaling(DXDC.Scaling openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Logarithmic Base.
  /// </summary>
  [DataMember]
  public Double? LogBase
  {
    get => _Element?.GetIntVal<Double, DXDC.LogBase>();
    set => _ExistingElement.SetIntVal<Double, DXDC.LogBase>(value);
  }
  
  
  /// <summary>
  ///   Axis Orientation.
  /// </summary>
  [DataMember]
  public DMDC.OrientationKind? Orientation
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Maximum.
  /// </summary>
  [DataMember]
  public DMDC.MaxAxisValue? MaxAxisValue
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.DoubleType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.DoubleType");
  }
  
  
  /// <summary>
  ///   Minimum.
  /// </summary>
  [DataMember]
  public DMDC.MinAxisValue? MinAxisValue
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.DoubleType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.DoubleType");
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
