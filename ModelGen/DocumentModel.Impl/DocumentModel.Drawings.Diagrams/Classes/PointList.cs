namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Point List.
/// </summary>
public class PointListImpl: ModelElementImpl, PointList
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.PointList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.PointList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PointListImpl(): base() {}
  
  public PointListImpl(DocumentFormat.OpenXml.Drawing.Diagrams.PointList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Diagrams.Point>? Points
  {
    get
    {
      if (_Points != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Point>()
            .Select(item => new DocumentModel.Drawings.Diagrams.PointImpl(item)).ToList();
          _Points = new ObservableCollection<DocumentModel.Drawings.Diagrams.Point>(items);
        }
        else
          _Points = new ObservableCollection<DocumentModel.Drawings.Diagrams.Point>();
        _Points.CollectionChanged += _Points_CollectionChanged;
      }
      return _Points;
    }
    set
    {
      if (value != null && value != _Points && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Point>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Diagrams.PointImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Diagrams.Point> observableCollection)
        _Points = observableCollection;
      else if (value != null)
        _Points = new ObservableCollection<DocumentModel.Drawings.Diagrams.Point>(value);
      else
       _Points = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Diagrams.Point>? _Points;
  
  private void _Points_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Point>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Diagrams.PointImpl valImpl)
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
              if (val is DocumentModel.Drawings.Diagrams.PointImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Point>()
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
