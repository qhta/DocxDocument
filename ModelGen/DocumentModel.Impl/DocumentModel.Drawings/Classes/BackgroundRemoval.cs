namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BackgroundRemoval Class.
/// </summary>
public class BackgroundRemovalImpl: ModelElementImpl, BackgroundRemoval
{
  public DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BackgroundRemovalImpl(): base() {}
  
  public BackgroundRemovalImpl(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// t, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeTop
  {
    get => (System.Int32?)OpenXmlElement?.MarqueeTop?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MarqueeTop = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// b, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeBottom
  {
    get => (System.Int32?)OpenXmlElement?.MarqueeBottom?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MarqueeBottom = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// l, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeLeft
  {
    get => (System.Int32?)OpenXmlElement?.MarqueeLeft?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MarqueeLeft = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// r, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeRight
  {
    get => (System.Int32?)OpenXmlElement?.MarqueeRight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MarqueeRight = (System.Int32?)value;
    }
  }
  
  public Collection<DocumentModel.Drawings.ForegroundMark>? ForegroundMarks
  {
    get
    {
      if (_ForegroundMarks != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark>()
            .Select(item => new DocumentModel.Drawings.ForegroundMarkImpl(item)).ToList();
          _ForegroundMarks = new ObservableCollection<DocumentModel.Drawings.ForegroundMark>(items);
        }
        else
          _ForegroundMarks = new ObservableCollection<DocumentModel.Drawings.ForegroundMark>();
        _ForegroundMarks.CollectionChanged += _ForegroundMarks_CollectionChanged;
      }
      return _ForegroundMarks;
    }
    set
    {
      if (value != null && value != _ForegroundMarks && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.ForegroundMarkImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ForegroundMark> observableCollection)
        _ForegroundMarks = observableCollection;
      else if (value != null)
        _ForegroundMarks = new ObservableCollection<DocumentModel.Drawings.ForegroundMark>(value);
      else
       _ForegroundMarks = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ForegroundMark>? _ForegroundMarks;
  
  private void _ForegroundMarks_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.ForegroundMarkImpl valImpl)
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
              if (val is DocumentModel.Drawings.ForegroundMarkImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark>()
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
  
  
  public Collection<DocumentModel.Drawings.BackgroundMark>? BackgroundMarks
  {
    get
    {
      if (_BackgroundMarks != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark>()
            .Select(item => new DocumentModel.Drawings.BackgroundMarkImpl(item)).ToList();
          _BackgroundMarks = new ObservableCollection<DocumentModel.Drawings.BackgroundMark>(items);
        }
        else
          _BackgroundMarks = new ObservableCollection<DocumentModel.Drawings.BackgroundMark>();
        _BackgroundMarks.CollectionChanged += _BackgroundMarks_CollectionChanged;
      }
      return _BackgroundMarks;
    }
    set
    {
      if (value != null && value != _BackgroundMarks && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.BackgroundMarkImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.BackgroundMark> observableCollection)
        _BackgroundMarks = observableCollection;
      else if (value != null)
        _BackgroundMarks = new ObservableCollection<DocumentModel.Drawings.BackgroundMark>(value);
      else
       _BackgroundMarks = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.BackgroundMark>? _BackgroundMarks;
  
  private void _BackgroundMarks_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.BackgroundMarkImpl valImpl)
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
              if (val is DocumentModel.Drawings.BackgroundMarkImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark>()
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
