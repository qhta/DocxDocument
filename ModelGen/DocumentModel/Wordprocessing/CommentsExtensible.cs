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
      var element = _Element?.GetFirstChild<DXO21WCE.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21WCE.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXO21WCE.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
