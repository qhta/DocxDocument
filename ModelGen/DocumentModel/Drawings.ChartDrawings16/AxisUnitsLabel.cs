namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the AxisUnitsLabel Class.
/// </summary>
public partial class AxisUnitsLabel: ModelElement<DXO16DCD.AxisUnitsLabel>
{
  public AxisUnitsLabel(): base(){ }
  
  public AxisUnitsLabel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AxisUnitsLabel(DXO16DCD.AxisUnitsLabel openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Text.
  /// </summary>
  [DataMember]
  public DMDCD16.Text? Text
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  [DataMember]
  public DMDCD16.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   TxPrTextBody.
  /// </summary>
  [DataMember]
  public DMDCD16.TxPrTextBody? TxPrTextBody
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextBodyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextBodyType");
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
