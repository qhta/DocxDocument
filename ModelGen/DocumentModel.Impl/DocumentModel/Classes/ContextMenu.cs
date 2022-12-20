namespace DocumentModel;

/// <summary>
/// Defines the ContextMenu Class.
/// </summary>
public partial class ContextMenuImpl: ModelElementImpl, ContextMenu
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ContextMenuImpl(): base() {}
  
  public ContextMenuImpl(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? IdMso
  {
    get => (System.String?)OpenXmlElement?.IdMso?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.IdMso = (System.String?)value;
    }
  }
  
  public DocumentModel.ControlCloneRegular? ControlCloneRegular
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular>();
        if (item != null)
          return new DocumentModel.ControlCloneRegularImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.ControlCloneRegularImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.ButtonRegular? ButtonRegular
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
        if (item != null)
          return new DocumentModel.ButtonRegularImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.ButtonRegularImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.CheckBox? CheckBox
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox>();
        if (item != null)
          return new DocumentModel.CheckBoxImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.CheckBoxImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.GalleryRegular? GalleryRegular
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular>();
        if (item != null)
          return new DocumentModel.GalleryRegularImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.GalleryRegularImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.ToggleButtonRegular? ToggleButtonRegular
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular>();
        if (item != null)
          return new DocumentModel.ToggleButtonRegularImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.ToggleButtonRegularImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.SplitButtonRegular? SplitButtonRegular
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular>();
        if (item != null)
          return new DocumentModel.SplitButtonRegularImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.SplitButtonRegularImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.MenuRegular? MenuRegular
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular>();
        if (item != null)
          return new DocumentModel.MenuRegularImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.MenuRegularImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.DynamicMenuRegular? DynamicMenuRegular
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular>();
        if (item != null)
          return new DocumentModel.DynamicMenuRegularImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.DynamicMenuRegularImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.MenuSeparatorNoTitle? MenuSeparatorNoTitle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparatorNoTitle>();
        if (item != null)
          return new DocumentModel.MenuSeparatorNoTitleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparatorNoTitle>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.MenuSeparatorNoTitleImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
