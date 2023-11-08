namespace DocumentModel.Drawings;


/// <summary>
///   Defines the HyperlinkOnMouseOver Class.
/// </summary>
public partial class HyperlinkOnMouseOver: ModelElement<DXD.HyperlinkOnMouseOver>
{
  public HyperlinkOnMouseOver(): base(){ }
  
  public HyperlinkOnMouseOver(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HyperlinkOnMouseOver(DXD.HyperlinkOnMouseOver openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMD.HyperlinkSound? HyperlinkSound
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.HyperlinkSound>();
      if (element != null)
        return HyperlinkSoundConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.HyperlinkSound>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HyperlinkSoundConverter.CreateOpenXmlElement<DXD.HyperlinkSound>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.HyperlinkExtensionList? HyperlinkExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.HyperlinkExtensionList>();
      if (element != null)
        return HyperlinkExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.HyperlinkExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HyperlinkExtensionListConverter.CreateOpenXmlElement<DXD.HyperlinkExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
