namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the Layout Class.
/// </summary>
public partial class Layout: ModelElement<DXO13DC.Layout>
{
  public Layout(): base(){ }
  
  public Layout(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Layout(DXO13DC.Layout openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Manual Layout.
  /// </summary>
  [DataMember]
  public DMDC.ManualLayout? ManualLayout
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
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
