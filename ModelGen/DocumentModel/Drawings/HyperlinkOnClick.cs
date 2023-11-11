namespace DocumentModel.Drawings;


/// <summary>
///   Defines the HyperlinkOnClick Class.
/// </summary>
public partial class HyperlinkOnClick: ModelElement<DXD.HyperlinkOnClick>
{
  public HyperlinkOnClick(): base(){ }
  
  public HyperlinkOnClick(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HyperlinkOnClick(DXD.HyperlinkOnClick openXmlElement): base(openXmlElement) { }
  
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
