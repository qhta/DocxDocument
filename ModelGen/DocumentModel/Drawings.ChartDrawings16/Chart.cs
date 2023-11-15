namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Chart Class.
/// </summary>
public partial class Chart: ModelElement<DXO16DCD.Chart>
{
  public Chart(): base(){ }
  
  public Chart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Chart(DXO16DCD.Chart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ChartTitle.
  /// </summary>
  [DataMember]
  public DMDCD16.ChartTitle? ChartTitle
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   PlotArea.
  /// </summary>
  [DataMember]
  public DMDCD16.PlotArea? PlotArea
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Legend.
  /// </summary>
  [DataMember]
  public DMDCD16.Legend? Legend
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
