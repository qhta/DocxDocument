namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the GeoLocationQueryResults Class.
/// </summary>
public class GeoLocationQueryResultsImpl: ModelElementImpl, GeoLocationQueryResults
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResults? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResults?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoLocationQueryResultsImpl(): base() {}
  
  public GeoLocationQueryResultsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResults openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings16.Charts.GeoLocationQueryResult>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult>()
            .Select(item => new DocumentModel.Drawings16.Charts.GeoLocationQueryResultImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Drawings16.Charts.GeoLocationQueryResult>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Drawings16.Charts.GeoLocationQueryResult>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings16.Charts.GeoLocationQueryResultImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings16.Charts.GeoLocationQueryResult> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Drawings16.Charts.GeoLocationQueryResult>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings16.Charts.GeoLocationQueryResult>? _Items;
  
  private void _Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings16.Charts.GeoLocationQueryResultImpl valImpl)
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
        if (val is DocumentModel.Drawings16.Charts.GeoLocationQueryResultImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult>()
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
