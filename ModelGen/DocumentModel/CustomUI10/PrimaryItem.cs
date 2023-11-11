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
      return _Element?.GetObject<DMCUI10.BackstageRegularButton,DXO10CUI.BackstageRegularButton>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI10.BackstageRegularButton,DXO10CUI.BackstageRegularButton>(value);
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
      return _Element?.GetObject<DMCUI10.BackstagePrimaryMenu,DXO10CUI.BackstagePrimaryMenu>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI10.BackstagePrimaryMenu,DXO10CUI.BackstagePrimaryMenu>(value);
    }
  }
  
}
