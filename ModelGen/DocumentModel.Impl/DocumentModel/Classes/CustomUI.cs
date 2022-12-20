namespace DocumentModel;

/// <summary>
/// Defines the CustomUI Class.
/// </summary>
public partial class CustomUIImpl: ModelElementImpl, CustomUI
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public CustomUIImpl(): base() {}
  
  public CustomUIImpl(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// onLoad, this property is only available in Office 2010 and later.
  /// </summary>
  public String? OnLoad
  {
    get => (System.String?)OpenXmlElement?.OnLoad?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OnLoad = (System.String?)value;
    }
  }
  
  /// <summary>
  /// loadImage, this property is only available in Office 2010 and later.
  /// </summary>
  public String? LoadImage
  {
    get => (System.String?)OpenXmlElement?.LoadImage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LoadImage = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Commands.
  /// </summary>
  public DocumentModel.Commands? Commands
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Commands>();
        if (item != null)
          return new DocumentModel.CommandsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Commands>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.CommandsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Ribbon.
  /// </summary>
  public DocumentModel.Ribbon? Ribbon
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon>();
        if (item != null)
          return new DocumentModel.RibbonImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.RibbonImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Backstage.
  /// </summary>
  public DocumentModel.Backstage? Backstage
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Backstage>();
        if (item != null)
          return new DocumentModel.BackstageImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Backstage>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.BackstageImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ContextMenus.
  /// </summary>
  public DocumentModel.ContextMenus? ContextMenus
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus>();
        if (item != null)
          return new DocumentModel.ContextMenusImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.ContextMenusImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
