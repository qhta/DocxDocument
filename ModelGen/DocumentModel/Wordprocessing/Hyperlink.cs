namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the Hyperlink Class.
/// </summary>
public partial class Hyperlink: ModelElement<DXW.Hyperlink>
{
  public Hyperlink(): base(){ }
  
  public Hyperlink(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Hyperlink(DXW.Hyperlink openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Hyperlink Target Frame
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
  ///   Associated String
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
  ///   Location in Target Document
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
  ///   Add To Viewed Hyperlinks
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
  ///   Hyperlink Anchor
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
  ///   Hyperlink Target
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
