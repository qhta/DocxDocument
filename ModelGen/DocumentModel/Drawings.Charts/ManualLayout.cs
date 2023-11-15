namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Manual Layout.
/// </summary>
public partial class ManualLayout: ModelElement<DXDC.ManualLayout>
{
  public ManualLayout(): base(){ }
  
  public ManualLayout(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ManualLayout(DXDC.ManualLayout openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Layout Target.
  /// </summary>
  [DataMember]
  public DMDC.LayoutTargetKind? LayoutTarget
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Left Mode.
  /// </summary>
  [DataMember]
  public DMDC.LeftMode? LeftMode
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.LayoutModeType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.LayoutModeType");
  }
  
  
  /// <summary>
  ///   Top Mode.
  /// </summary>
  [DataMember]
  public DMDC.TopMode? TopMode
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.LayoutModeType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.LayoutModeType");
  }
  
  
  /// <summary>
  ///   Width Mode.
  /// </summary>
  [DataMember]
  public DMDC.WidthMode? WidthMode
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.LayoutModeType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.LayoutModeType");
  }
  
  
  /// <summary>
  ///   Height Mode.
  /// </summary>
  [DataMember]
  public DMDC.HeightMode? HeightMode
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.LayoutModeType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.LayoutModeType");
  }
  
  
  /// <summary>
  ///   Left.
  /// </summary>
  [DataMember]
  public DMDC.Left? Left
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.DoubleType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.DoubleType");
  }
  
  
  /// <summary>
  ///   Top.
  /// </summary>
  [DataMember]
  public DMDC.Top? Top
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.DoubleType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.DoubleType");
  }
  
  
  /// <summary>
  ///   Width.
  /// </summary>
  [DataMember]
  public DMDC.Width? Width
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.DoubleType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.DoubleType");
  }
  
  
  /// <summary>
  ///   Height.
  /// </summary>
  [DataMember]
  public DMDC.Height? Height
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
