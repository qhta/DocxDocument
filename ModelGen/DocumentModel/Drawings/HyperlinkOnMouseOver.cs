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
