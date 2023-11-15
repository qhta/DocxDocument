namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the BubbleChartExtension Class.
/// </summary>
public partial class BubbleChartExtension: ModelElement<DXDC.BubbleChartExtension>
{
  public BubbleChartExtension(): base(){ }
  
  public BubbleChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BubbleChartExtension(DXDC.BubbleChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC13.FilteredBubbleSeries? FilteredBubbleSeries
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
