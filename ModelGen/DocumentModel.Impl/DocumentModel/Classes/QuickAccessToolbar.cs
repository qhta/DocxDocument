namespace DocumentModel;

/// <summary>
/// Defines the QuickAccessToolbar Class.
/// </summary>
public partial class QuickAccessToolbarImpl: ModelElementImpl, QuickAccessToolbar
{
  public DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public QuickAccessToolbarImpl(): base() {}
  
  public QuickAccessToolbarImpl(DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// SharedControlsQatItems.
  /// </summary>
  public DocumentModel.SharedControlsQatItems? SharedControlsQatItems
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SharedControlsQatItems>();
        if (item != null)
          return new DocumentModel.SharedControlsQatItemsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SharedControlsQatItems>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.SharedControlsQatItemsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// DocumentControlsQatItems.
  /// </summary>
  public DocumentModel.DocumentControlsQatItems? DocumentControlsQatItems
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems>();
        if (item != null)
          return new DocumentModel.DocumentControlsQatItemsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.DocumentControlsQatItemsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
