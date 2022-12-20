namespace DocumentModel.UI;

/// <summary>
/// Defines the Ribbon Class.
/// </summary>
public partial class RibbonImpl: ModelElementImpl, Ribbon
{
  public DocumentFormat.OpenXml.Office.CustomUI.Ribbon? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.CustomUI.Ribbon?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RibbonImpl(): base() {}
  
  public RibbonImpl(DocumentFormat.OpenXml.Office.CustomUI.Ribbon openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// startFromScratch
  /// </summary>
  public Boolean? StartFromScratch
  {
    get => (System.Boolean?)OpenXmlElement?.StartFromScratch?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StartFromScratch = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// OfficeMenu.
  /// </summary>
  public DocumentModel.UI.OfficeMenu? OfficeMenu
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu>();
        if (item != null)
          return new DocumentModel.UI.OfficeMenuImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.OfficeMenuImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// QuickAccessToolbar.
  /// </summary>
  public DocumentModel.UI.QuickAccessToolbar? QuickAccessToolbar
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar>();
        if (item != null)
          return new DocumentModel.UI.QuickAccessToolbarImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.QuickAccessToolbarImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  public DocumentModel.UI.Tabs? Tabs
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Tabs>();
        if (item != null)
          return new DocumentModel.UI.TabsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Tabs>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.TabsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ContextualTabSets.
  /// </summary>
  public DocumentModel.UI.ContextualTabSets? ContextualTabSets
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSets>();
        if (item != null)
          return new DocumentModel.UI.ContextualTabSetsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSets>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.ContextualTabSetsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
