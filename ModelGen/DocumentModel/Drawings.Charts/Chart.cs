namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Chart Class.
/// </summary>
public partial class Chart: ModelElement<DXDC.Chart>
{
  public Chart(): base(){ }
  
  public Chart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Chart(DXDC.Chart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Title data and formatting.
  /// </summary>
  [DataMember]
  public DMDC.Title? Title
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   True if the chart automatic title has been deleted..
  /// </summary>
  [DataMember]
  public DMDC.AutoTitleDeleted? AutoTitleDeleted
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
  }
  
  
  /// <summary>
  ///   pivot chart format persistence data.
  /// </summary>
  [DataMember]
  public DMDC.PivotFormats? PivotFormats
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   3D view settings.
  /// </summary>
  [DataMember]
  public DMDC.View3D? View3D
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   3D floor formatting.
  /// </summary>
  [DataMember]
  public DMDC.Floor? Floor
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.SurfaceType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.SurfaceType");
  }
  
  
  /// <summary>
  ///   3D side wall formatting.
  /// </summary>
  [DataMember]
  public DMDC.SideWall? SideWall
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.SurfaceType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.SurfaceType");
  }
  
  
  /// <summary>
  ///   3D back wall formatting.
  /// </summary>
  [DataMember]
  public DMDC.BackWall? BackWall
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.SurfaceType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.SurfaceType");
  }
  
  
  /// <summary>
  ///   Plot data and formatting.
  /// </summary>
  [DataMember]
  public DMDC.PlotArea? PlotArea
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Legend data and formatting.
  /// </summary>
  [DataMember]
  public DMDC.Legend? Legend
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   True if only visible cells are plotted..
  /// </summary>
  [DataMember]
  public DMDC.PlotVisibleOnly? PlotVisibleOnly
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
  }
  
  
  /// <summary>
  ///   The way that blank cells are plotted on a chart..
  /// </summary>
  [DataMember]
  public DMDC.DisplayBlanksAsKind? DisplayBlanksAs
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   True if we should render datalabels over the maximum scale.
  /// </summary>
  [DataMember]
  public DMDC.ShowDataLabelsOverMaximum? ShowDataLabelsOverMaximum
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
  }
  
  
  /// <summary>
  ///   Extensibility container.
  /// </summary>
  [DataMember]
  public DMDC.ChartExtensionList? ChartExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
