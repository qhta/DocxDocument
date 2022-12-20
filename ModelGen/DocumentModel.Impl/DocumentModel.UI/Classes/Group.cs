namespace DocumentModel.UI;

/// <summary>
/// Defines the Group Class.
/// </summary>
public partial class GroupImpl: ModelElementImpl, Group
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.CustomUI.Group? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.CustomUI.Group?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public GroupImpl(): base() {}
  
  public GroupImpl(DocumentFormat.OpenXml.Office.CustomUI.Group openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// id
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
  /// idQ
  /// </summary>
  public String? IdQ
  {
    get => (System.String?)OpenXmlElement?.IdQ?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.IdQ = (System.String?)value;
    }
  }
  
  /// <summary>
  /// idMso
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
  /// tag
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
  /// label
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
  /// getLabel
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
  /// image
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
  /// imageMso
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
  /// getImage
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
  /// insertAfterMso
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
  /// insertBeforeMso
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
  /// insertAfterQ
  /// </summary>
  public String? InsertAfterQ
  {
    get => (System.String?)OpenXmlElement?.InsertAfterQ?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsertAfterQ = (System.String?)value;
    }
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  public String? InsertBeforeQ
  {
    get => (System.String?)OpenXmlElement?.InsertBeforeQ?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsertBeforeQ = (System.String?)value;
    }
  }
  
  /// <summary>
  /// screentip
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
  /// getScreentip
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
  /// supertip
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
  /// getSupertip
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
  /// visible
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
  /// getVisible
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
  /// keytip
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
  /// getKeytip
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
  
  public DocumentModel.UI.ControlClone? ControlClone
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ControlClone>();
        if (item != null)
          return new DocumentModel.UI.ControlCloneImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ControlClone>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.ControlCloneImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.UI.TextLabel? TextLabel
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.TextLabel>();
        if (item != null)
          return new DocumentModel.UI.TextLabelImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.TextLabel>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.TextLabelImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.UI.Button? Button
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Button>();
        if (item != null)
          return new DocumentModel.UI.ButtonImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Button>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.ButtonImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.UI.ToggleButton? ToggleButton
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ToggleButton>();
        if (item != null)
          return new DocumentModel.UI.ToggleButtonImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ToggleButton>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.ToggleButtonImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.UI.CheckBox? CheckBox
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>();
        if (item != null)
          return new DocumentModel.UI.CheckBoxImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.CheckBoxImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.UI.EditBox? EditBox
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.EditBox>();
        if (item != null)
          return new DocumentModel.UI.EditBoxImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.EditBox>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.EditBoxImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.UI.ComboBox? ComboBox
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ComboBox>();
        if (item != null)
          return new DocumentModel.UI.ComboBoxImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ComboBox>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.ComboBoxImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.UI.DropDown? DropDown
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.DropDown>();
        if (item != null)
          return new DocumentModel.UI.DropDownImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.DropDown>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.DropDownImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.UI.Gallery? Gallery
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Gallery>();
        if (item != null)
          return new DocumentModel.UI.GalleryImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Gallery>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.GalleryImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.UI.Menu? Menu
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Menu>();
        if (item != null)
          return new DocumentModel.UI.MenuImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Menu>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.MenuImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.UI.DynamicMenu? DynamicMenu
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.DynamicMenu>();
        if (item != null)
          return new DocumentModel.UI.DynamicMenuImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.DynamicMenu>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.DynamicMenuImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.UI.SplitButton? SplitButton
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.SplitButton>();
        if (item != null)
          return new DocumentModel.UI.SplitButtonImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.SplitButton>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.SplitButtonImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.UI.Box? Box
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Box>();
        if (item != null)
          return new DocumentModel.UI.BoxImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Box>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.BoxImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.UI.ButtonGroup? ButtonGroup
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup>();
        if (item != null)
          return new DocumentModel.UI.ButtonGroupImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.ButtonGroupImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.UI.VerticalSeparator? VerticalSeparator
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator>();
        if (item != null)
          return new DocumentModel.UI.VerticalSeparatorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.VerticalSeparatorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.UI.DialogBoxLauncher? DialogBoxLauncher
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.DialogBoxLauncher>();
        if (item != null)
          return new DocumentModel.UI.DialogBoxLauncherImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.DialogBoxLauncher>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.DialogBoxLauncherImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
