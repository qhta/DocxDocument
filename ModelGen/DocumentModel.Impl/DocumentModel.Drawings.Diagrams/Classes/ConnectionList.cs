namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Connection List.
/// </summary>
public class ConnectionListImpl: ModelElementImpl, ConnectionList
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ConnectionListImpl(): base() {}
  
  public ConnectionListImpl(DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Diagrams.Connection>? Connections
  {
    get
    {
      if (_Connections != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Connection>()
            .Select(item => new DocumentModel.Drawings.Diagrams.ConnectionImpl(item)).ToList();
          _Connections = new ObservableCollection<DocumentModel.Drawings.Diagrams.Connection>(items);
        }
        else
          _Connections = new ObservableCollection<DocumentModel.Drawings.Diagrams.Connection>();
        _Connections.CollectionChanged += _Connections_CollectionChanged;
      }
      return _Connections;
    }
    set
    {
      if (value != null && value != _Connections && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Connection>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Diagrams.ConnectionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Diagrams.Connection> observableCollection)
        _Connections = observableCollection;
      else if (value != null)
        _Connections = new ObservableCollection<DocumentModel.Drawings.Diagrams.Connection>(value);
      else
       _Connections = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Diagrams.Connection>? _Connections;
  
  private void _Connections_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Connection>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Diagrams.ConnectionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Diagrams.ConnectionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Connection>()
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
