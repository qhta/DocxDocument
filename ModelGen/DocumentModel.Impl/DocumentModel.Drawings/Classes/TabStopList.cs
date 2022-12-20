namespace DocumentModel.Drawings;

/// <summary>
/// Tab List.
/// </summary>
public partial class TabStopListImpl: ModelElementImpl, TabStopList
{
  public DocumentFormat.OpenXml.Drawing.TabStopList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.TabStopList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TabStopListImpl(): base() {}
  
  public TabStopListImpl(DocumentFormat.OpenXml.Drawing.TabStopList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.TabStop>? TabStops
  {
    get
    {
      if (_TabStops != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.TabStop>()
            .Select(item => new DocumentModel.Drawings.TabStopImpl(item)).ToList();
          _TabStops = new ObservableCollection<DocumentModel.Drawings.TabStop>(items);
        }
        else
          _TabStops = new ObservableCollection<DocumentModel.Drawings.TabStop>();
        _TabStops.CollectionChanged += _TabStops_CollectionChanged;
      }
      return _TabStops;
    }
    set
    {
      if (value != null && value != _TabStops && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.TabStop>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.TabStopImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.TabStop> observableCollection)
        _TabStops = observableCollection;
      else if (value != null)
        _TabStops = new ObservableCollection<DocumentModel.Drawings.TabStop>(value);
      else
       _TabStops = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.TabStop>? _TabStops;
  
  private void _TabStops_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.TabStop>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.TabStopImpl valImpl)
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
              if (val is DocumentModel.Drawings.TabStopImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.TabStop>()
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
