namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Definition Instance.
/// </summary>
public partial class NumberingInstanceImpl: ModelElementImpl, NumberingInstance
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.NumberingInstance? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.NumberingInstance?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public NumberingInstanceImpl(): base() {}
  
  public NumberingInstanceImpl(DocumentFormat.OpenXml.Wordprocessing.NumberingInstance openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// numId
  /// </summary>
  public Int32? NumberID
  {
    get => (System.Int32?)OpenXmlElement?.NumberID?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NumberID = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// durableId
  /// </summary>
  public Int32? DurableId
  {
    get => (System.Int32?)OpenXmlElement?.DurableId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DurableId = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// AbstractNumId.
  /// </summary>
  public Int32? AbstractNumId
  {
    get => (System.Int32?)OpenXmlElement?.AbstractNumId?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.AbstractNumId != null)
        {
          if (value is not null)
            OpenXmlElement.AbstractNumId.Val = (System.Int32?)value;
          else
            OpenXmlElement.AbstractNumId = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.AbstractNumId = new DocumentFormat.OpenXml.Wordprocessing.AbstractNumId{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  public Collection<DocumentModel.Wordprocessing.LevelOverride>? LevelOverrides
  {
    get
    {
      if (_LevelOverrides == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.LevelOverride>()
            .Select(item => new DocumentModel.Wordprocessing.LevelOverrideImpl(item)).ToList();
          _LevelOverrides = new ObservableCollection<DocumentModel.Wordprocessing.LevelOverride>(items);
        }
        else
          _LevelOverrides = new ObservableCollection<DocumentModel.Wordprocessing.LevelOverride>();
        _LevelOverrides.CollectionChanged += _LevelOverrides_CollectionChanged;
      }
      return _LevelOverrides;
    }
    set
    {
      if (value != null && value != _LevelOverrides && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.LevelOverride>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Wordprocessing.LevelOverrideImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.LevelOverride> observableCollection)
        _LevelOverrides = observableCollection;
      else if (value != null)
        _LevelOverrides = new ObservableCollection<DocumentModel.Wordprocessing.LevelOverride>(value);
      else
       _LevelOverrides = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.LevelOverride>? _LevelOverrides;
  
  private void _LevelOverrides_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.LevelOverride>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Wordprocessing.LevelOverrideImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.LevelOverrideImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.LevelOverride>()
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
