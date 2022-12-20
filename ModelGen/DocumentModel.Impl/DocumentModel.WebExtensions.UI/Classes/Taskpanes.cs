namespace DocumentModel.WebExtensions.UI;

/// <summary>
/// Defines the Taskpanes Class.
/// </summary>
public partial class TaskpanesImpl: ModelElementImpl, Taskpanes
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2013.WebExtentionPane.Taskpanes? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.WebExtentionPane.Taskpanes?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TaskpanesImpl(): base() {}
  
  public TaskpanesImpl(DocumentFormat.OpenXml.Office2013.WebExtentionPane.Taskpanes openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.WebExtensions.UI.WebExtensionTaskpane>? WebExtensionTaskpanes
  {
    get
    {
      if (_WebExtensionTaskpanes == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane>()
            .Select(item => new DocumentModel.WebExtensions.UI.WebExtensionTaskpaneImpl(item)).ToList();
          _WebExtensionTaskpanes = new ObservableCollection<DocumentModel.WebExtensions.UI.WebExtensionTaskpane>(items);
        }
        else
          _WebExtensionTaskpanes = new ObservableCollection<DocumentModel.WebExtensions.UI.WebExtensionTaskpane>();
        _WebExtensionTaskpanes.CollectionChanged += _WebExtensionTaskpanes_CollectionChanged;
      }
      return _WebExtensionTaskpanes;
    }
    set
    {
      if (value != null && value != _WebExtensionTaskpanes && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane>();
        foreach (var val in value)
        {
          if (val is DocumentModel.WebExtensions.UI.WebExtensionTaskpaneImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.WebExtensions.UI.WebExtensionTaskpane> observableCollection)
        _WebExtensionTaskpanes = observableCollection;
      else if (value != null)
        _WebExtensionTaskpanes = new ObservableCollection<DocumentModel.WebExtensions.UI.WebExtensionTaskpane>(value);
      else
       _WebExtensionTaskpanes = null;
    }
  }
  private ObservableCollection<DocumentModel.WebExtensions.UI.WebExtensionTaskpane>? _WebExtensionTaskpanes;
  
  private void _WebExtensionTaskpanes_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.WebExtensions.UI.WebExtensionTaskpaneImpl valImpl)
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
              if (val is DocumentModel.WebExtensions.UI.WebExtensionTaskpaneImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane>()
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
