namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the Ribbon Class.
/// </summary>
public partial class Ribbon: ModelElement<DXO10CUI.Ribbon>
{
  public Ribbon(): base(){ }
  
  public Ribbon(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Ribbon(DXO10CUI.Ribbon openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   startFromScratch, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? StartFromScratch
  {
    get => _Element?.StartFromScratch?.Value;
    set => _ExistingElement.StartFromScratch = value;
  }
  
  
  /// <summary>
  ///   QuickAccessToolbar.
  /// </summary>
  [DataMember]
  public DMCUI10.QuickAccessToolbar? QuickAccessToolbar
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Tabs.
  /// </summary>
  [DataMember]
  public DMCUI10.Tabs? Tabs
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   ContextualTabs.
  /// </summary>
  [DataMember]
  public DMCUI10.ContextualTabs? ContextualTabs
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
