namespace DocumentModel.CustomUI;


/// <summary>
///   Defines the Ribbon Class.
/// </summary>
public partial class Ribbon: ModelElement<DXOCUI.Ribbon>
{
  public Ribbon(): base(){ }
  
  public Ribbon(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Ribbon(DXOCUI.Ribbon openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   startFromScratch
  /// </summary>
  [DataMember]
  public Boolean? StartFromScratch
  {
    get => _Element?.StartFromScratch?.Value;
    set => _ExistingElement.StartFromScratch = value;
  }
  
  
  /// <summary>
  ///   OfficeMenu.
  /// </summary>
  [DataMember]
  public DMCUI.OfficeMenu? OfficeMenu
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   QuickAccessToolbar.
  /// </summary>
  [DataMember]
  public DMCUI.QuickAccessToolbar? QuickAccessToolbar
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Tabs.
  /// </summary>
  [DataMember]
  public DMCUI.Tabs? Tabs
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   ContextualTabSets.
  /// </summary>
  [DataMember]
  public DMCUI.ContextualTabSets? ContextualTabSets
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
