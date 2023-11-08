namespace DocumentModel.Wordprocessing;


/// <summary>
///   Listing of All Revision Save ID Values.
/// </summary>
public partial class Rsids: ModelElement<DXW.Rsids>
{
  public Rsids(): base(){ }
  
  public Rsids(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Rsids(DXW.Rsids openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Original Document Revision Save ID.
  /// </summary>
  [DataMember]
  public DMW.RsidRoot? RsidRoot
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.RsidRoot>();
      if (element != null)
        return RsidRootConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RsidRoot>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RsidRootConverter.CreateOpenXmlElement<DXW.RsidRoot>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
