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
      var element = _Element?.GetFirstChild<DXO10CUI.SharedControlsQatItems>();
      if (element != null)
        return SharedControlsQatItemsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10CUI.SharedControlsQatItems>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SharedControlsQatItemsConverter.CreateOpenXmlElement<DXO10CUI.SharedControlsQatItems>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO10CUI.DocumentControlsQatItems>();
      if (element != null)
        return DocumentControlsQatItemsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10CUI.DocumentControlsQatItems>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentControlsQatItemsConverter.CreateOpenXmlElement<DXO10CUI.DocumentControlsQatItems>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
