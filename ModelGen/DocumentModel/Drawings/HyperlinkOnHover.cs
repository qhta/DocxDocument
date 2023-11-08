namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the hyperlink information to be activated when the user's mouse is hovered over the corresponding object. The operation of the hyperlink is to have the specified action be activated when the mouse of the user hovers over the object. When this action is activated then additional attributes can be used to specify other tasks that should be performed along with the action.
/// </summary>
public partial class HyperlinkOnHover: ModelElement<DXD.HyperlinkOnHover>
{
  public HyperlinkOnHover(): base(){ }
  
  public HyperlinkOnHover(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HyperlinkOnHover(DXD.HyperlinkOnHover openXmlElement): base(openXmlElement) { }
  
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
