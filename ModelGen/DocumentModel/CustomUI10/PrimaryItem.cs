namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the PrimaryItem Class.
/// </summary>
public partial class PrimaryItem: ModelElement<DXO10CUI.PrimaryItem>
{
  public PrimaryItem(): base(){ }
  
  public PrimaryItem(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PrimaryItem(DXO10CUI.PrimaryItem openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   BackstageRegularButton.
  /// </summary>
  [DataMember]
  public DMCUI10.BackstageRegularButton? BackstageRegularButton
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10CUI.BackstageRegularButton>();
      if (element != null)
        return BackstageRegularButtonConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10CUI.BackstageRegularButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackstageRegularButtonConverter.CreateOpenXmlElement<DXO10CUI.BackstageRegularButton>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   BackstagePrimaryMenu.
  /// </summary>
  [DataMember]
  public DMCUI10.BackstagePrimaryMenu? BackstagePrimaryMenu
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10CUI.BackstagePrimaryMenu>();
      if (element != null)
        return BackstagePrimaryMenuConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10CUI.BackstagePrimaryMenu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackstagePrimaryMenuConverter.CreateOpenXmlElement<DXO10CUI.BackstagePrimaryMenu>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
