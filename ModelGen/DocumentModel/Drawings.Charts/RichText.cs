namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Rich Text.
/// </summary>
public partial class RichText: ModelElement<DXDC.RichText>
{
  public RichText(): base(){ }
  
  public RichText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RichText(DXDC.RichText openXmlElement): base(openXmlElement) { }
  
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
