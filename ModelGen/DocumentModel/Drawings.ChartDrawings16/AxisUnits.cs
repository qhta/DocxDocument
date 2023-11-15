namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the AxisUnits Class.
/// </summary>
public partial class AxisUnits: ModelElement<DXO16DCD.AxisUnits>
{
  public AxisUnits(): base(){ }
  
  public AxisUnits(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AxisUnits(DXO16DCD.AxisUnits openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   AxisUnitsLabel.
  /// </summary>
  [DataMember]
  public DMDCD16.AxisUnitsLabel? AxisUnitsLabel
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
