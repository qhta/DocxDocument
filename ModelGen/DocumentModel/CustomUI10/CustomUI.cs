namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the CustomUI Class.
/// </summary>
public partial class CustomUI: ModelElement<DXO10CUI.CustomUI>
{
  public CustomUI(): base(){ }
  
  public CustomUI(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomUI(DXO10CUI.CustomUI openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   onLoad, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? OnLoad
  {
    get => _Element?.OnLoad;
    set => _ExistingElement.OnLoad = value;
  }
  
  
  /// <summary>
  ///   loadImage, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? LoadImage
  {
    get => _Element?.LoadImage;
    set => _ExistingElement.LoadImage = value;
  }
  
  
  /// <summary>
  ///   Commands.
  /// </summary>
  [DataMember]
  public DMCUI10.Commands? Commands
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Ribbon.
  /// </summary>
  [DataMember]
  public DMCUI10.Ribbon? Ribbon
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Backstage.
  /// </summary>
  [DataMember]
  public DMCUI10.Backstage? Backstage
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   ContextMenus.
  /// </summary>
  [DataMember]
  public DMCUI10.ContextMenus? ContextMenus
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
}
