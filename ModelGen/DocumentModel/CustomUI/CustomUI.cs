namespace DocumentModel.CustomUI;


/// <summary>
///   Defines the CustomUI Class.
/// </summary>
public partial class CustomUI: ModelElement<DXOCUI.CustomUI>
{
  public CustomUI(): base(){ }
  
  public CustomUI(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomUI(DXOCUI.CustomUI openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   onLoad
  /// </summary>
  [DataMember]
  public String? OnLoad
  {
    get => _Element?.OnLoad;
    set => _ExistingElement.OnLoad = value;
  }
  
  
  /// <summary>
  ///   loadImage
  /// </summary>
  [DataMember]
  public String? LoadImage
  {
    get => _Element?.LoadImage;
    set => _ExistingElement.LoadImage = value;
  }
  
  
  /// <summary>
  ///   RepurposedCommands.
  /// </summary>
  [DataMember]
  public DMCUI.RepurposedCommands? RepurposedCommands
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Ribbon.
  /// </summary>
  [DataMember]
  public DMCUI.Ribbon? Ribbon
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
}
