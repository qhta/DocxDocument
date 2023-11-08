namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the TextBodyType Class.
/// </summary>
public partial class TextBodyType: ModelElement<DXDC.TextBodyType>
{
  public TextBodyType(): base(){ }
  
  public TextBodyType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextBodyType(DXDC.TextBodyType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Body Properties.
  /// </summary>
  [DataMember]
  public DMD.BodyProperties? BodyProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.BodyProperties>();
      if (element != null)
        return BodyPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.BodyProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BodyPropertiesConverter.CreateOpenXmlElement<DXD.BodyProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Text List Styles.
  /// </summary>
  [DataMember]
  public DMD.ListStyle? ListStyle
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ListStyle>();
      if (element != null)
        return ListStyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ListStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ListStyleConverter.CreateOpenXmlElement<DXD.ListStyle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
