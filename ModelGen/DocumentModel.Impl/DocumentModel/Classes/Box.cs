namespace DocumentModel;

/// <summary>
/// Defines the Box Class.
/// </summary>
public partial class BoxImpl: ModelElementImpl, Box
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.CustomUI.Box? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.Box?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BoxImpl(): base() {}
  
  public BoxImpl(DocumentFormat.OpenXml.Office2010.CustomUI.Box openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
  /// boxStyle, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.BoxStyleKind? BoxStyle
  {
    get => (DocumentModel.BoxStyleKind?)OpenXmlElement?.BoxStyle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BoxStyle = (DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues?)value;
    }
  }
  
  public DocumentModel.ControlClone? ControlClone
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlClone>();
        if (item != null)
          return new DocumentModel.ControlCloneImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlClone>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.ControlCloneImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.LabelControl? LabelControl
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.LabelControl>();
        if (item != null)
          return new DocumentModel.LabelControlImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.LabelControl>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.LabelControlImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Button? Button
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Button>();
        if (item != null)
          return new DocumentModel.ButtonImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Button>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.ButtonImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.ToggleButton? ToggleButton
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButton>();
        if (item != null)
          return new DocumentModel.ToggleButtonImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButton>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.ToggleButtonImpl)?.OpenXmlElement;
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
  
  public DocumentModel.EditBox? EditBox
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.EditBox>();
        if (item != null)
          return new DocumentModel.EditBoxImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.EditBox>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.EditBoxImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.ComboBox? ComboBox
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ComboBox>();
        if (item != null)
          return new DocumentModel.ComboBoxImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ComboBox>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.ComboBoxImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.DropDownRegular? DropDownRegular
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular>();
        if (item != null)
          return new DocumentModel.DropDownRegularImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.DropDownRegularImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Gallery? Gallery
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Gallery>();
        if (item != null)
          return new DocumentModel.GalleryImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Gallery>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.GalleryImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Menu? Menu
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Menu>();
        if (item != null)
          return new DocumentModel.MenuImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Menu>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.MenuImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.DynamicMenu? DynamicMenu
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenu>();
        if (item != null)
          return new DocumentModel.DynamicMenuImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenu>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.DynamicMenuImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.SplitButton? SplitButton
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButton>();
        if (item != null)
          return new DocumentModel.SplitButtonImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButton>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.SplitButtonImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Box? ChildBox
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Box>();
        if (item != null)
          return new DocumentModel.BoxImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Box>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.BoxImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.ButtonGroup? ButtonGroup
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup>();
        if (item != null)
          return new DocumentModel.ButtonGroupImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.ButtonGroupImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
