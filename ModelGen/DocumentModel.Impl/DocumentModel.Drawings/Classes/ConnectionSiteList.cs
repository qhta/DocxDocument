namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Connection Sites.
/// </summary>
public partial class ConnectionSiteListImpl: ModelElementImpl, ConnectionSiteList
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.ConnectionSiteList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ConnectionSiteList?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ConnectionSiteListImpl(): base() {}
  
  public ConnectionSiteListImpl(DocumentFormat.OpenXml.Drawing.ConnectionSiteList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.ConnectionSite>? ConnectionSites
  {
    get
    {
      if (_ConnectionSites == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ConnectionSite>()
            .Select(item => new DocumentModel.Drawings.ConnectionSiteImpl(item)).ToList();
          _ConnectionSites = new ObservableCollection<DocumentModel.Drawings.ConnectionSite>(items);
        }
        else
          _ConnectionSites = new ObservableCollection<DocumentModel.Drawings.ConnectionSite>();
        _ConnectionSites.CollectionChanged += _ConnectionSites_CollectionChanged;
      }
      return _ConnectionSites;
    }
    set
    {
      if (value != null && value != _ConnectionSites && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ConnectionSite>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.ConnectionSiteImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ConnectionSite> observableCollection)
        _ConnectionSites = observableCollection;
      else if (value != null)
        _ConnectionSites = new ObservableCollection<DocumentModel.Drawings.ConnectionSite>(value);
      else
       _ConnectionSites = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ConnectionSite>? _ConnectionSites;
  
  private void _ConnectionSites_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ConnectionSite>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.ConnectionSiteImpl valImpl)
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
              if (val is DocumentModel.Drawings.ConnectionSiteImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ConnectionSite>()
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
