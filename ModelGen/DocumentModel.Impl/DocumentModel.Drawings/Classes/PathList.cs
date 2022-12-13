namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Paths.
/// </summary>
public class PathListImpl: ModelElementImpl, PathList
{
  public DocumentFormat.OpenXml.Drawing.PathList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.PathList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PathListImpl(): base() {}
  
  public PathListImpl(DocumentFormat.OpenXml.Drawing.PathList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Path>? Paths
  {
    get
    {
      if (_Paths != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Path>()
            .Select(item => new DocumentModel.Drawings.PathImpl(item)).ToList();
          _Paths = new ObservableCollection<DocumentModel.Drawings.Path>(items);
        }
        else
          _Paths = new ObservableCollection<DocumentModel.Drawings.Path>();
        _Paths.CollectionChanged += _Paths_CollectionChanged;
      }
      return _Paths;
    }
    set
    {
      if (value != null && value != _Paths && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Path>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.PathImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Path> observableCollection)
        _Paths = observableCollection;
      else if (value != null)
        _Paths = new ObservableCollection<DocumentModel.Drawings.Path>(value);
      else
       _Paths = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Path>? _Paths;
  
  private void _Paths_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Path>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.PathImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          foreach (var val in args.OldItems)
          {
        if (val is DocumentModel.Drawings.PathImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Path>()
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
