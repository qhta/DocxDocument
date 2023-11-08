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
      var element = _Element?.GetFirstChild<DXOCUI.SharedQatControls>();
      if (element != null)
        return SharedQatControlsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOCUI.SharedQatControls>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SharedQatControlsConverter.CreateOpenXmlElement<DXOCUI.SharedQatControls>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXOCUI.DocumentSpecificQuickAccessToolbarControls>();
      if (element != null)
        return DocumentSpecificQuickAccessToolbarControlsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOCUI.DocumentSpecificQuickAccessToolbarControls>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentSpecificQuickAccessToolbarControlsConverter.CreateOpenXmlElement<DXOCUI.DocumentSpecificQuickAccessToolbarControls>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
