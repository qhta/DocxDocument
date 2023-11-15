namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the BackgroundRemoval Class.
/// </summary>
public partial class BackgroundRemoval: ModelElement<DXO10D.BackgroundRemoval>
{
  public BackgroundRemoval(): base(){ }
  
  public BackgroundRemoval(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackgroundRemoval(DXO10D.BackgroundRemoval openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   t, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? MarqueeTop
  {
    get => _Element?.MarqueeTop?.Value;
    set => _ExistingElement.MarqueeTop = value;
  }
  
  
  /// <summary>
  ///   b, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? MarqueeBottom
  {
    get => _Element?.MarqueeBottom?.Value;
    set => _ExistingElement.MarqueeBottom = value;
  }
  
  
  /// <summary>
  ///   l, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? MarqueeLeft
  {
    get => _Element?.MarqueeLeft?.Value;
    set => _ExistingElement.MarqueeLeft = value;
  }
  
  
  /// <summary>
  ///   r, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? MarqueeRight
  {
    get => _Element?.MarqueeRight?.Value;
    set => _ExistingElement.MarqueeRight = value;
  }
  
}
