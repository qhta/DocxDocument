namespace DocumentModel;

/// <summary>
/// Defines the TaskFormGroupCategory Class.
/// </summary>
public partial class TaskFormGroupCategoryImpl: ModelElementImpl, TaskFormGroupCategory
{
  public DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupCategory? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupCategory?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TaskFormGroupCategoryImpl(): base() {}
  
  public TaskFormGroupCategoryImpl(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupCategory openXmlElement): base(openXmlElement)
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
  
  public Collection<DocumentModel.TaskFormGroupTask>? TaskFormGroupTasks
  {
    get
    {
      if (_TaskFormGroupTasks != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupTask>()
            .Select(item => new DocumentModel.TaskFormGroupTaskImpl(item)).ToList();
          _TaskFormGroupTasks = new ObservableCollection<DocumentModel.TaskFormGroupTask>(items);
        }
        else
          _TaskFormGroupTasks = new ObservableCollection<DocumentModel.TaskFormGroupTask>();
        _TaskFormGroupTasks.CollectionChanged += _TaskFormGroupTasks_CollectionChanged;
      }
      return _TaskFormGroupTasks;
    }
    set
    {
      if (value != null && value != _TaskFormGroupTasks && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupTask>();
        foreach (var val in value)
        {
          if (val is DocumentModel.TaskFormGroupTaskImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.TaskFormGroupTask> observableCollection)
        _TaskFormGroupTasks = observableCollection;
      else if (value != null)
        _TaskFormGroupTasks = new ObservableCollection<DocumentModel.TaskFormGroupTask>(value);
      else
       _TaskFormGroupTasks = null;
    }
  }
  private ObservableCollection<DocumentModel.TaskFormGroupTask>? _TaskFormGroupTasks;
  
  private void _TaskFormGroupTasks_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupTask>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.TaskFormGroupTaskImpl valImpl)
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
              if (val is DocumentModel.TaskFormGroupTaskImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupTask>()
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
