namespace DocumentModel;

/// <summary>
/// Defines the TaskHistory Class.
/// </summary>
public partial class TaskHistoryImpl: ModelElementImpl, TaskHistory
{
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TaskHistoryImpl(): base() {}
  
  public TaskHistoryImpl(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.TaskHistoryEvent>? TaskHistoryEvents
  {
    get
    {
      if (_TaskHistoryEvents != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent>()
            .Select(item => new DocumentModel.TaskHistoryEventImpl(item)).ToList();
          _TaskHistoryEvents = new ObservableCollection<DocumentModel.TaskHistoryEvent>(items);
        }
        else
          _TaskHistoryEvents = new ObservableCollection<DocumentModel.TaskHistoryEvent>();
        _TaskHistoryEvents.CollectionChanged += _TaskHistoryEvents_CollectionChanged;
      }
      return _TaskHistoryEvents;
    }
    set
    {
      if (value != null && value != _TaskHistoryEvents && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent>();
        foreach (var val in value)
        {
          if (val is DocumentModel.TaskHistoryEventImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.TaskHistoryEvent> observableCollection)
        _TaskHistoryEvents = observableCollection;
      else if (value != null)
        _TaskHistoryEvents = new ObservableCollection<DocumentModel.TaskHistoryEvent>(value);
      else
       _TaskHistoryEvents = null;
    }
  }
  private ObservableCollection<DocumentModel.TaskHistoryEvent>? _TaskHistoryEvents;
  
  private void _TaskHistoryEvents_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.TaskHistoryEventImpl valImpl)
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
              if (val is DocumentModel.TaskHistoryEventImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent>()
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
