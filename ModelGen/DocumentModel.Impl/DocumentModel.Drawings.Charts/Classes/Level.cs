namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Level.
/// </summary>
public partial class LevelImpl: ModelElementImpl, Level
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.Level? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Level?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public LevelImpl(): base() {}
  
  public LevelImpl(DocumentFormat.OpenXml.Drawing.Charts.Level openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.StringPoint>? StringPoints
  {
    get
    {
      if (_StringPoints == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>()
            .Select(item => new DocumentModel.Drawings.Charts.StringPointImpl(item)).ToList();
          _StringPoints = new ObservableCollection<DocumentModel.Drawings.Charts.StringPoint>(items);
        }
        else
          _StringPoints = new ObservableCollection<DocumentModel.Drawings.Charts.StringPoint>();
        _StringPoints.CollectionChanged += _StringPoints_CollectionChanged;
      }
      return _StringPoints;
    }
    set
    {
      if (value != null && value != _StringPoints && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.StringPointImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.StringPoint> observableCollection)
        _StringPoints = observableCollection;
      else if (value != null)
        _StringPoints = new ObservableCollection<DocumentModel.Drawings.Charts.StringPoint>(value);
      else
       _StringPoints = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.StringPoint>? _StringPoints;
  
  private void _StringPoints_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.StringPointImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.StringPointImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>()
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
