namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the GeoChildEntitiesQueryResults Class.
/// </summary>
public class GeoChildEntitiesQueryResultsImpl: ModelElementImpl, GeoChildEntitiesQueryResults
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResults? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResults?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoChildEntitiesQueryResultsImpl(): base() {}
  
  public GeoChildEntitiesQueryResultsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResults openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings16.Charts.GeoChildEntitiesQueryResult>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult>()
            .Select(item => new DocumentModel.Drawings16.Charts.GeoChildEntitiesQueryResultImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Drawings16.Charts.GeoChildEntitiesQueryResult>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Drawings16.Charts.GeoChildEntitiesQueryResult>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings16.Charts.GeoChildEntitiesQueryResultImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings16.Charts.GeoChildEntitiesQueryResult> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Drawings16.Charts.GeoChildEntitiesQueryResult>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings16.Charts.GeoChildEntitiesQueryResult>? _Items;
  
  private void _Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings16.Charts.GeoChildEntitiesQueryResultImpl valImpl)
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
        if (val is DocumentModel.Drawings16.Charts.GeoChildEntitiesQueryResultImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult>()
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
