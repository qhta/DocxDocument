namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the PivotSource Class.
/// </summary>
public partial class PivotSource: ModelElement<DXDC.PivotSource>
{
  public PivotSource(): base(){ }
  
  public PivotSource(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PivotSource(DXDC.PivotSource openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Pivot Name.
  /// </summary>
  [DataMember]
  public DMDC.PivotTableName? PivotTableName
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   Format ID.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? FormatId
  {
    get => _Element?.GetHexIntVal<DXDC.FormatId>();
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
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
