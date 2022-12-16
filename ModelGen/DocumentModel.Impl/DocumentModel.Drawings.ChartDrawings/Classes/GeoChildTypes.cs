namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildTypes Class.
/// </summary>
public class GeoChildTypesImpl: ModelElementImpl, GeoChildTypes
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildTypes? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildTypes?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoChildTypesImpl(): base() {}
  
  public GeoChildTypesImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildTypes openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<System.String>? EntityTypes
  {
    get
    {
      if (_EntityTypes != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityType>()
            .Select(item => item.Text).ToList();
          _EntityTypes = new ObservableCollection<System.String>(items);
        }
        else
          _EntityTypes = new ObservableCollection<System.String>();
        _EntityTypes.CollectionChanged += _EntityTypes_CollectionChanged;
      }
      return _EntityTypes;
    }
    set
    {
      if (value != null && value != _EntityTypes && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityType>();
        foreach (var val in value)
        {
        if (val is string str)
        {
          var item = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityType{ Text = str };
          OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<System.String> observableCollection)
        _EntityTypes = observableCollection;
      else if (value != null)
        _EntityTypes = new ObservableCollection<System.String>(value);
      else
       _EntityTypes = null;
    }
  }
  private ObservableCollection<System.String>? _EntityTypes;
  
  private void _EntityTypes_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityType>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is string str)
          {
            var newItem = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityType { Text = str };
            OpenXmlElement.AddChild(newItem);
          };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          foreach (var val in args.OldItems)
          {
        if (val is string str)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityType>()
                          .FirstOrDefault(anItem => anItem.Text == str);
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
