namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the MultiLevelStringCache Class.
/// </summary>
public partial class MultiLevelStringCacheImpl: ModelElementImpl, MultiLevelStringCache
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public MultiLevelStringCacheImpl(): base() {}
  
  public MultiLevelStringCacheImpl(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// PointCount.
  /// </summary>
  public UInt32? PointCount
  {
    get => (System.UInt32?)OpenXmlElement?.PointCount?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PointCount != null)
        {
          if (value is not null)
            OpenXmlElement.PointCount.Val = (System.UInt32?)value;
          else
            OpenXmlElement.PointCount = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PointCount = new DocumentFormat.OpenXml.Drawing.Charts.PointCount{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  public Collection<DocumentModel.Drawings.Charts.Level>? Levels
  {
    get
    {
      if (_Levels == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Level>()
            .Select(item => new DocumentModel.Drawings.Charts.LevelImpl(item)).ToList();
          _Levels = new ObservableCollection<DocumentModel.Drawings.Charts.Level>(items);
        }
        else
          _Levels = new ObservableCollection<DocumentModel.Drawings.Charts.Level>();
        _Levels.CollectionChanged += _Levels_CollectionChanged;
      }
      return _Levels;
    }
    set
    {
      if (value != null && value != _Levels && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Level>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.LevelImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.Level> observableCollection)
        _Levels = observableCollection;
      else if (value != null)
        _Levels = new ObservableCollection<DocumentModel.Drawings.Charts.Level>(value);
      else
       _Levels = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.Level>? _Levels;
  
  private void _Levels_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Level>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.LevelImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.LevelImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Level>()
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
  
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
