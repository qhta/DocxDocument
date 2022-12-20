namespace DocumentModel;

/// <summary>
/// Defines the MenuRegular Class.
/// </summary>
public partial class MenuRegularImpl: ModelElementImpl, MenuRegular
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public MenuRegularImpl(): base() {}
  
  public MenuRegularImpl(DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// itemSize, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.ItemSizeKind? ItemSize
  {
    get => (DocumentModel.ItemSizeKind?)OpenXmlElement?.ItemSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ItemSize = (DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues?)value;
    }
  }
  
  /// <summary>
  /// description, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Description
  {
    get => (System.String?)OpenXmlElement?.Description?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Description = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getDescription, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetDescription
  {
    get => (System.String?)OpenXmlElement?.GetDescription?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetDescription = (System.String?)value;
    }
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? QualifiedId
  {
    get => (System.String?)OpenXmlElement?.QualifiedId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.QualifiedId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Tag
  {
    get => (System.String?)OpenXmlElement?.Tag?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Tag = (System.String?)value;
    }
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
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Image
  {
    get => (System.String?)OpenXmlElement?.Image?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Image = (System.String?)value;
    }
  }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? ImageMso
  {
    get => (System.String?)OpenXmlElement?.ImageMso?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ImageMso = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetImage
  {
    get => (System.String?)OpenXmlElement?.GetImage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetImage = (System.String?)value;
    }
  }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Screentip
  {
    get => (System.String?)OpenXmlElement?.Screentip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Screentip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetScreentip
  {
    get => (System.String?)OpenXmlElement?.GetScreentip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetScreentip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Supertip
  {
    get => (System.String?)OpenXmlElement?.Supertip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Supertip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetSupertip
  {
    get => (System.String?)OpenXmlElement?.GetSupertip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetSupertip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Enabled
  {
    get => (System.Boolean?)OpenXmlElement?.Enabled?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Enabled = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetEnabled
  {
    get => (System.String?)OpenXmlElement?.GetEnabled?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetEnabled = (System.String?)value;
    }
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Label
  {
    get => (System.String?)OpenXmlElement?.Label?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Label = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetLabel
  {
    get => (System.String?)OpenXmlElement?.GetLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetLabel = (System.String?)value;
    }
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertAfterMso
  {
    get => (System.String?)OpenXmlElement?.InsertAfterMso?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsertAfterMso = (System.String?)value;
    }
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertBeforeMso
  {
    get => (System.String?)OpenXmlElement?.InsertBeforeMso?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsertBeforeMso = (System.String?)value;
    }
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertAfterQulifiedId
  {
    get => (System.String?)OpenXmlElement?.InsertAfterQulifiedId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsertAfterQulifiedId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertBeforeQulifiedId
  {
    get => (System.String?)OpenXmlElement?.InsertBeforeQulifiedId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsertBeforeQulifiedId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Visible
  {
    get => (System.Boolean?)OpenXmlElement?.Visible?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Visible = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetVisible
  {
    get => (System.String?)OpenXmlElement?.GetVisible?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetVisible = (System.String?)value;
    }
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Keytip
  {
    get => (System.String?)OpenXmlElement?.Keytip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Keytip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetKeytip
  {
    get => (System.String?)OpenXmlElement?.GetKeytip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetKeytip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? ShowLabel
  {
    get => (System.Boolean?)OpenXmlElement?.ShowLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShowLabel = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetShowLabel
  {
    get => (System.String?)OpenXmlElement?.GetShowLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetShowLabel = (System.String?)value;
    }
  }
  
  /// <summary>
  /// showImage, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? ShowImage
  {
    get => (System.Boolean?)OpenXmlElement?.ShowImage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShowImage = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// getShowImage, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetShowImage
  {
    get => (System.String?)OpenXmlElement?.GetShowImage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetShowImage = (System.String?)value;
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
  
  public DocumentModel.MenuSeparator? MenuSeparator
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator>();
        if (item != null)
          return new DocumentModel.MenuSeparatorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.MenuSeparatorImpl)?.OpenXmlElement;
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
  
  public DocumentModel.MenuRegular? ChildMenuRegular
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
  
}
