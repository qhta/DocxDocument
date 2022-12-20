namespace DocumentModel;

/// <summary>
/// Defines the Tabs Class.
/// </summary>
public partial class TabsImpl: ModelElementImpl, Tabs
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.CustomUI.Tabs? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.Tabs?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TabsImpl(): base() {}
  
  public TabsImpl(DocumentFormat.OpenXml.Office2010.CustomUI.Tabs openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Tab>? Items
  {
    get
    {
      if (_Items == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.Tab>()
            .Select(item => new DocumentModel.TabImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Tab>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Tab>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.Tab>();
        foreach (var val in value)
        {
          if (val is DocumentModel.TabImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Tab> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Tab>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Tab>? _Items;
  
  private void _Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.Tab>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.TabImpl valImpl)
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
              if (val is DocumentModel.TabImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.Tab>()
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
