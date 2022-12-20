namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoParentEntitiesQueryResults Class.
/// </summary>
public partial class GeoParentEntitiesQueryResultsImpl: ModelElementImpl, GeoParentEntitiesQueryResults
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResults? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResults?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public GeoParentEntitiesQueryResultsImpl(): base() {}
  
  public GeoParentEntitiesQueryResultsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResults openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResult>? Items
  {
    get
    {
      if (_Items == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult>()
            .Select(item => new DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResultImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResult>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResult>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResultImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResult> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResult>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResult>? _Items;
  
  private void _Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResultImpl valImpl)
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
              if (val is DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResultImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult>()
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
