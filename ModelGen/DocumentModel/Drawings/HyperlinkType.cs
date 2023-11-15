namespace DocumentModel.Drawings;


/// <summary>
///   Defines the HyperlinkType Class.
/// </summary>
public partial class HyperlinkType: ModelElement<DXD.HyperlinkType>
{
  public HyperlinkType(): base(){ }
  
  public HyperlinkType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HyperlinkType(DXD.HyperlinkType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   relationship identifier to find target URI
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
  
  /// <summary>
  ///   In case the url is invalid so we can't create a relationship, we'll save it here, r:id will point to a NULL one
  /// </summary>
  [DataMember]
  public String? InvalidUrl
  {
    get => _Element?.InvalidUrl;
    set => _ExistingElement.InvalidUrl = value;
  }
  
  
  /// <summary>
  ///   Action to take, it may still need r:id to specify an action target
  /// </summary>
  [DataMember]
  public String? Action
  {
    get => _Element?.Action;
    set => _ExistingElement.Action = value;
  }
  
  
  /// <summary>
  ///   target frame for navigating to the URI
  /// </summary>
  [DataMember]
  public String? TargetFrame
  {
    get => _Element?.TargetFrame;
    set => _ExistingElement.TargetFrame = value;
  }
  
  
  /// <summary>
  ///   tooltip for display
  /// </summary>
  [DataMember]
  public String? Tooltip
  {
    get => _Element?.Tooltip;
    set => _ExistingElement.Tooltip = value;
  }
  
  
  /// <summary>
  ///   whether to add this URI to the history when navigating to it
  /// </summary>
  [DataMember]
  public Boolean? History
  {
    get => _Element?.History?.Value;
    set => _ExistingElement.History = value;
  }
  
  
  /// <summary>
  ///   Whether to highlight it when click on a shape
  /// </summary>
  [DataMember]
  public Boolean? HighlightClick
  {
    get => _Element?.HighlightClick?.Value;
    set => _ExistingElement.HighlightClick = value;
  }
  
  
  /// <summary>
  ///   Whether to stop previous sound when click on it
  /// </summary>
  [DataMember]
  public Boolean? EndSound
  {
    get => _Element?.EndSound?.Value;
    set => _ExistingElement.EndSound = value;
  }
  
  
  /// <summary>
  ///   Sound to play..
  /// </summary>
  [DataMember]
  public DMD.HyperlinkSound? HyperlinkSound
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType");
  }
  
  
  /// <summary>
  ///   Future extensions..
  /// </summary>
  [DataMember]
  public DMD.HyperlinkExtensionList? HyperlinkExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
