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
    get
    {
      return StringValueConverter.GetValue(_Element?.TargetFrame);
    }
    set
    {
      _ExistingElement.TargetFrame = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   tooltip
  /// </summary>
  [DataMember]
  public String? Tooltip
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Tooltip);
    }
    set
    {
      _ExistingElement.Tooltip = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   docLocation
  /// </summary>
  [DataMember]
  public String? DocLocation
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.DocLocation);
    }
    set
    {
      _ExistingElement.DocLocation = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   history
  /// </summary>
  [DataMember]
  public Boolean? History
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.History);
    }
    set
    {
      _ExistingElement.History = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   anchor
  /// </summary>
  [DataMember]
  public String? Anchor
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Anchor);
    }
    set
    {
      _ExistingElement.Anchor = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   id
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
