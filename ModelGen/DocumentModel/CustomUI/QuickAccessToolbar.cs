namespace DocumentModel.CustomUI;


/// <summary>
///   Defines the QuickAccessToolbar Class.
/// </summary>
public partial class QuickAccessToolbar: ModelElement<DXOCUI.QuickAccessToolbar>
{
  public QuickAccessToolbar(): base(){ }
  
  public QuickAccessToolbar(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public QuickAccessToolbar(DXOCUI.QuickAccessToolbar openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   SharedQatControls.
  /// </summary>
  [DataMember]
  public DMCUI.SharedQatControls? SharedQatControls
  {
    get
    {
      return _Element?.GetObject<DMCUI.SharedQatControls,DXOCUI.SharedQatControls>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI.SharedQatControls,DXOCUI.SharedQatControls>(value);
    }
  }
  
  
  /// <summary>
  ///   DocumentSpecificQuickAccessToolbarControls.
  /// </summary>
  [DataMember]
  public DMCUI.DocumentSpecificQuickAccessToolbarControls? DocumentSpecificQuickAccessToolbarControls
  {
    get
    {
      return _Element?.GetObject<DMCUI.DocumentSpecificQuickAccessToolbarControls,DXOCUI.DocumentSpecificQuickAccessToolbarControls>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI.DocumentSpecificQuickAccessToolbarControls,DXOCUI.DocumentSpecificQuickAccessToolbarControls>(value);
    }
  }
  
}
