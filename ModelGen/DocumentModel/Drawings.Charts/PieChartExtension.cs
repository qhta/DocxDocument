namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the PieChartExtension Class.
/// </summary>
public partial class PieChartExtension: ModelElement<DXDC.PieChartExtension>
{
  public PieChartExtension(): base(){ }
  
  public PieChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PieChartExtension(DXDC.PieChartExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   URI
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get => _Element?.Uri;
    set => _ExistingElement.Uri = value;
  }
  
  [DataMember]
  public DMDC13.FilteredPieSeries? FilteredPieSeries
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
