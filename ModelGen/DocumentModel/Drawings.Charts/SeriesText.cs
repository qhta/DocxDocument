namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Series Text.
/// </summary>
public partial class SeriesText: ModelElement<DXDC.SeriesText>
{
  public SeriesText(): base(){ }
  
  public SeriesText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SeriesText(DXDC.SeriesText openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   StringReference.
  /// </summary>
  [DataMember]
  public DMDC.StringReference? StringReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   NumericValue.
  /// </summary>
  [DataMember]
  public DM.NumericValue? NumericValue
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
