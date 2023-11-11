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
      return _Element?.GetObject<DMD.HyperlinkSound,DXD.HyperlinkSound>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.HyperlinkSound,DXD.HyperlinkSound>(value);
    }
  }
  
  [DataMember]
  public DMD.HyperlinkExtensionList? HyperlinkExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.HyperlinkExtensionList,DXD.HyperlinkExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.HyperlinkExtensionList,DXD.HyperlinkExtensionList>(value);
    }
  }
  
}
