namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the UpDownBars Class.
/// </summary>
public partial class UpDownBars: ModelElement<DXDC.UpDownBars>
{
  public UpDownBars(): base(){ }
  
  public UpDownBars(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UpDownBars(DXDC.UpDownBars openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gap Width.
  /// </summary>
  [DataMember]
  public DMDC.GapWidth? GapWidth
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.GapAmountType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.GapAmountType");
  }
  
  
  /// <summary>
  ///   Up Bars.
  /// </summary>
  [DataMember]
  public DMDC.UpBars? UpBars
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.UpDownBarType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.UpDownBarType");
  }
  
  
  /// <summary>
  ///   Down Bars.
  /// </summary>
  [DataMember]
  public DMDC.DownBars? DownBars
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.UpDownBarType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.UpDownBarType");
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
