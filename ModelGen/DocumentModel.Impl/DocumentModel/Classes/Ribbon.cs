namespace DocumentModel;

/// <summary>
/// Defines the Ribbon Class.
/// </summary>
public partial class RibbonImpl: ModelElementImpl, Ribbon
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public RibbonImpl(): base() {}
  
  public RibbonImpl(DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// startFromScratch, this property is only available in Office 2010 and later.
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
  /// QuickAccessToolbar.
  /// </summary>
  public DocumentModel.QuickAccessToolbar? QuickAccessToolbar
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar>();
        if (item != null)
          return new DocumentModel.QuickAccessToolbarImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.QuickAccessToolbarImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  public DocumentModel.Tabs? Tabs
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Tabs>();
        if (item != null)
          return new DocumentModel.TabsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Tabs>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.TabsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ContextualTabs.
  /// </summary>
  public DocumentModel.ContextualTabs? ContextualTabs
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs>();
        if (item != null)
          return new DocumentModel.ContextualTabsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.ContextualTabsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
