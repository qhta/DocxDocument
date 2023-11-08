namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Defines the WebVideoProperty Class.
/// </summary>
public partial class WebVideoProperty: ModelElement<DXO13WD.WebVideoProperty>
{
  public WebVideoProperty(): base(){ }
  
  public WebVideoProperty(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WebVideoProperty(DXO13WD.WebVideoProperty openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   embeddedHtml, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? EmbeddedHtml
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.EmbeddedHtml);
    }
    set
    {
      _ExistingElement.EmbeddedHtml = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   h, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public UInt32? Height
  {
    get
    {
      return _Element?.Height?.Value;
    }
    set
    {
      _ExistingElement.Height = value;
    }
  }
  
  
  /// <summary>
  ///   w, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public UInt32? Width
  {
    get
    {
      return _Element?.Width?.Value;
    }
    set
    {
      _ExistingElement.Width = value;
    }
  }
  
}
