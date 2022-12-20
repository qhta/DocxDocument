namespace DocumentModel;

/// <summary>
/// Defines the TaskGroup Class.
/// </summary>
public partial class TaskGroupImpl: ModelElementImpl, TaskGroup
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TaskGroupImpl(): base() {}
  
  public TaskGroupImpl(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup openXmlElement): base(openXmlElement)
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
  /// helperText, this property is only available in Office 2010 and later.
  /// </summary>
  public String? HelperText
  {
    get => (System.String?)OpenXmlElement?.HelperText?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HelperText = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getHelperText, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetHelperText
  {
    get => (System.String?)OpenXmlElement?.GetHelperText?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetHelperText = (System.String?)value;
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
  /// allowedTaskSizes, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.TaskSizesKind? AllowedTaskSizes
  {
    get => (DocumentModel.TaskSizesKind?)OpenXmlElement?.AllowedTaskSizes?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AllowedTaskSizes = (DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues?)value;
    }
  }
  
  public Collection<DocumentModel.TaskGroupCategory>? TaskGroupCategories
  {
    get
    {
      if (_TaskGroupCategories == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupCategory>()
            .Select(item => new DocumentModel.TaskGroupCategoryImpl(item)).ToList();
          _TaskGroupCategories = new ObservableCollection<DocumentModel.TaskGroupCategory>(items);
        }
        else
          _TaskGroupCategories = new ObservableCollection<DocumentModel.TaskGroupCategory>();
        _TaskGroupCategories.CollectionChanged += _TaskGroupCategories_CollectionChanged;
      }
      return _TaskGroupCategories;
    }
    set
    {
      if (value != null && value != _TaskGroupCategories && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupCategory>();
        foreach (var val in value)
        {
          if (val is DocumentModel.TaskGroupCategoryImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.TaskGroupCategory> observableCollection)
        _TaskGroupCategories = observableCollection;
      else if (value != null)
        _TaskGroupCategories = new ObservableCollection<DocumentModel.TaskGroupCategory>(value);
      else
       _TaskGroupCategories = null;
    }
  }
  private ObservableCollection<DocumentModel.TaskGroupCategory>? _TaskGroupCategories;
  
  private void _TaskGroupCategories_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupCategory>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.TaskGroupCategoryImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddChild(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.TaskGroupCategoryImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupCategory>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    oldItem.Remove();
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
}
