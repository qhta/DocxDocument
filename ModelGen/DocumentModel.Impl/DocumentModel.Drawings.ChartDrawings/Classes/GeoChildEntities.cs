namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntities Class.
/// </summary>
public class GeoChildEntitiesImpl: ModelElementImpl, GeoChildEntities
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntities? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntities?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoChildEntitiesImpl(): base() {}
  
  public GeoChildEntitiesImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntities openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.ChartDrawings.GeoHierarchyEntity>? GeoHierarchyEntities
  {
    get
    {
      if (_GeoHierarchyEntities != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity>()
            .Select(item => new DocumentModel.Drawings.ChartDrawings.GeoHierarchyEntityImpl(item)).ToList();
          _GeoHierarchyEntities = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoHierarchyEntity>(items);
        }
        else
          _GeoHierarchyEntities = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoHierarchyEntity>();
        _GeoHierarchyEntities.CollectionChanged += _GeoHierarchyEntities_CollectionChanged;
      }
      return _GeoHierarchyEntities;
    }
    set
    {
      if (value != null && value != _GeoHierarchyEntities && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.ChartDrawings.GeoHierarchyEntityImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoHierarchyEntity> observableCollection)
        _GeoHierarchyEntities = observableCollection;
      else if (value != null)
        _GeoHierarchyEntities = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoHierarchyEntity>(value);
      else
       _GeoHierarchyEntities = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ChartDrawings.GeoHierarchyEntity>? _GeoHierarchyEntities;
  
  private void _GeoHierarchyEntities_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.ChartDrawings.GeoHierarchyEntityImpl valImpl)
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
        if (val is DocumentModel.Drawings.ChartDrawings.GeoHierarchyEntityImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity>()
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
