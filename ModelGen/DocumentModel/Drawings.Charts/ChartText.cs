namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ChartText Class.
/// </summary>
public partial class ChartText: ModelElement<DXDC.ChartText>
{
  public ChartText(): base(){ }
  
  public ChartText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartText(DXDC.ChartText openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   String Reference.
  /// </summary>
  [DataMember]
  public DMDC.StringReference? StringReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Rich Text.
  /// </summary>
  [DataMember]
  public DMDC.RichText? RichText
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.TextBodyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.TextBodyType");
  }
  
  
  /// <summary>
  ///   String Literal.
  /// </summary>
  [DataMember]
  public DMDC.StringLiteral? StringLiteral
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.StringDataType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.StringDataType");
  }
  
}
