namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the HyperlinkRuby Class.
/// </summary>
public partial class HyperlinkRuby: ModelElement<DXW.HyperlinkRuby>
{
  public HyperlinkRuby(): base(){ }
  
  public HyperlinkRuby(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HyperlinkRuby(DXW.HyperlinkRuby openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   tgtFrame
  /// </summary>
  [DataMember]
  public String? TargetFrame
  {
    get => _Element?.TargetFrame;
    set => _ExistingElement.TargetFrame = value;
  }
  
  
  /// <summary>
  ///   tooltip
  /// </summary>
  [DataMember]
  public String? Tooltip
  {
    get => _Element?.Tooltip;
    set => _ExistingElement.Tooltip = value;
  }
  
  
  /// <summary>
  ///   docLocation
  /// </summary>
  [DataMember]
  public String? DocLocation
  {
    get => _Element?.DocLocation;
    set => _ExistingElement.DocLocation = value;
  }
  
  
  /// <summary>
  ///   history
  /// </summary>
  [DataMember]
  public Boolean? History
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   anchor
  /// </summary>
  [DataMember]
  public String? Anchor
  {
    get => _Element?.Anchor;
    set => _ExistingElement.Anchor = value;
  }
  
  
  /// <summary>
  ///   id
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
}
