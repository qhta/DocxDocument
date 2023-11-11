namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CommentsExtensible Class.
/// </summary>
public partial class CommentsExtensible: ModelElement<DXO21WCE.CommentsExtensible>
{
  public CommentsExtensible(): base(){ }
  
  public CommentsExtensible(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CommentsExtensible(DXO21WCE.CommentsExtensible openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMW.ExtensionList,DXO21WCE.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ExtensionList,DXO21WCE.ExtensionList>(value);
    }
  }
  
}
