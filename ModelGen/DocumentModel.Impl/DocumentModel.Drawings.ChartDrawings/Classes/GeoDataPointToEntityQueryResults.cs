namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataPointToEntityQueryResults Class.
/// </summary>
public class GeoDataPointToEntityQueryResultsImpl: ModelElementImpl, GeoDataPointToEntityQueryResults
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResults? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResults?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoDataPointToEntityQueryResultsImpl(): base() {}
  
  public GeoDataPointToEntityQueryResultsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResults openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResult>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResult>()
            .Select(item => new DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResultImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResult>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResult>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResult>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResultImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResult> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResult>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResult>? _Items;
  
  private void _Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResult>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResultImpl valImpl)
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
        if (val is DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResultImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResult>()
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
