namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the QuickAccessToolbar Class.
/// </summary>
public partial class QuickAccessToolbar: ModelElement<DXO10CUI.QuickAccessToolbar>
{
  public QuickAccessToolbar(): base(){ }
  
  public QuickAccessToolbar(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public QuickAccessToolbar(DXO10CUI.QuickAccessToolbar openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   SharedControlsQatItems.
  /// </summary>
  [DataMember]
  public DMCUI10.SharedControlsQatItems? SharedControlsQatItems
  {
    get
    {
      return _Element?.GetObject<DMCUI10.SharedControlsQatItems,DXO10CUI.SharedControlsQatItems>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI10.SharedControlsQatItems,DXO10CUI.SharedControlsQatItems>(value);
    }
  }
  
  
  /// <summary>
  ///   DocumentControlsQatItems.
  /// </summary>
  [DataMember]
  public DMCUI10.DocumentControlsQatItems? DocumentControlsQatItems
  {
    get
    {
      return _Element?.GetObject<DMCUI10.DocumentControlsQatItems,DXO10CUI.DocumentControlsQatItems>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI10.DocumentControlsQatItems,DXO10CUI.DocumentControlsQatItems>(value);
    }
  }
  
}
