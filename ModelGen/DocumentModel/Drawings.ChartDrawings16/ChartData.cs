namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the ChartData Class.
/// </summary>
public partial class ChartData: ModelElement<DXO16DCD.ChartData>
{
  public ChartData(): base(){ }
  
  public ChartData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartData(DXO16DCD.ChartData openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ExternalData.
  /// </summary>
  [DataMember]
  public DMDCD16.ExternalData? ExternalData
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
