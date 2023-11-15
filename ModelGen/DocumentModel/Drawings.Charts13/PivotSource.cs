namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the PivotSource Class.
/// </summary>
public partial class PivotSource: ModelElement<DXO13DC.PivotSource>
{
  public PivotSource(): base(){ }
  
  public PivotSource(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PivotSource(DXO13DC.PivotSource openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC.FormatId? FormatId
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.UnsignedIntegerType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.UnsignedIntegerType");
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
