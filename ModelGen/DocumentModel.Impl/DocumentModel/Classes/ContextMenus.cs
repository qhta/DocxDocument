namespace DocumentModel;

/// <summary>
/// Defines the ContextMenus Class.
/// </summary>
public partial class ContextMenusImpl: ModelElementImpl, ContextMenus
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ContextMenusImpl(): base() {}
  
  public ContextMenusImpl(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.ContextMenu>? Items
  {
    get
    {
      if (_Items == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu>()
            .Select(item => new DocumentModel.ContextMenuImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.ContextMenu>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.ContextMenu>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu>();
        foreach (var val in value)
        {
          if (val is DocumentModel.ContextMenuImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.ContextMenu> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.ContextMenu>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.ContextMenu>? _Items;
  
  private void _Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.ContextMenuImpl valImpl)
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
              if (val is DocumentModel.ContextMenuImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu>()
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
