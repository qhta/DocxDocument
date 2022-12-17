namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoPolygons Class.
/// </summary>
public class GeoPolygonsImpl: ModelElementImpl, GeoPolygons
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygons? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygons?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoPolygonsImpl(): base() {}
  
  public GeoPolygonsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygons openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.ChartDrawings.GeoPolygon>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygon>()
            .Select(item => new DocumentModel.Drawings.ChartDrawings.GeoPolygonImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoPolygon>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoPolygon>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygon>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.ChartDrawings.GeoPolygonImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoPolygon> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoPolygon>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoPolygon>? _Items;
  
  private void _Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygon>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.ChartDrawings.GeoPolygonImpl valImpl)
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
              if (val is DocumentModel.Drawings.ChartDrawings.GeoPolygonImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygon>()
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
