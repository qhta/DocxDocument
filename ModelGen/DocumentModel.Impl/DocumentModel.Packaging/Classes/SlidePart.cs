namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlidePart
/// </summary>
public partial class SlidePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, SlidePart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.SlidePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.SlidePart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public SlidePartImpl(): base() {}
  
  public SlidePartImpl(DocumentFormat.OpenXml.Packaging.SlidePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the ChartParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartPart>? ChartParts
  {
    get
    {
      if (_ChartParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ChartPart>()
            .Select(item => new DocumentModel.Packaging.ChartPartImpl(item)).ToList();
          _ChartParts = new ObservableCollection<DocumentModel.Packaging.ChartPart>(items);
        }
        else
          _ChartParts = new ObservableCollection<DocumentModel.Packaging.ChartPart>();
        _ChartParts.CollectionChanged += _ChartParts_CollectionChanged;
      }
      return _ChartParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.ChartPart>? _ChartParts;
  
  private void _ChartParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ChartPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.ChartPartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.ChartPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ChartPart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets the commentParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.PowerPointCommentPart>? commentParts
  {
    get
    {
      if (_commentParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.PowerPointCommentPart>()
            .Select(item => new DocumentModel.Packaging.PowerPointCommentPartImpl(item)).ToList();
          _commentParts = new ObservableCollection<DocumentModel.Packaging.PowerPointCommentPart>(items);
        }
        else
          _commentParts = new ObservableCollection<DocumentModel.Packaging.PowerPointCommentPart>();
        _commentParts.CollectionChanged += _commentParts_CollectionChanged;
      }
      return _commentParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.PowerPointCommentPart>? _commentParts;
  
  private void _commentParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.PowerPointCommentPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.PowerPointCommentPartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.PowerPointCommentPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.PowerPointCommentPart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the CustomXmlParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.CustomXmlPart>? CustomXmlParts
  {
    get
    {
      if (_CustomXmlParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.CustomXmlPart>()
            .Select(item => new DocumentModel.Packaging.CustomXmlPartImpl(item)).ToList();
          _CustomXmlParts = new ObservableCollection<DocumentModel.Packaging.CustomXmlPart>(items);
        }
        else
          _CustomXmlParts = new ObservableCollection<DocumentModel.Packaging.CustomXmlPart>();
        _CustomXmlParts.CollectionChanged += _CustomXmlParts_CollectionChanged;
      }
      return _CustomXmlParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.CustomXmlPart>? _CustomXmlParts;
  
  private void _CustomXmlParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.CustomXmlPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.CustomXmlPartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.CustomXmlPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.CustomXmlPart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets the DiagramColorsParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramColorsPart>? DiagramColorsParts
  {
    get
    {
      if (_DiagramColorsParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramColorsPart>()
            .Select(item => new DocumentModel.Packaging.DiagramColorsPartImpl(item)).ToList();
          _DiagramColorsParts = new ObservableCollection<DocumentModel.Packaging.DiagramColorsPart>(items);
        }
        else
          _DiagramColorsParts = new ObservableCollection<DocumentModel.Packaging.DiagramColorsPart>();
        _DiagramColorsParts.CollectionChanged += _DiagramColorsParts_CollectionChanged;
      }
      return _DiagramColorsParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.DiagramColorsPart>? _DiagramColorsParts;
  
  private void _DiagramColorsParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramColorsPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.DiagramColorsPartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.DiagramColorsPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramColorsPart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets the DiagramDataParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramDataPart>? DiagramDataParts
  {
    get
    {
      if (_DiagramDataParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramDataPart>()
            .Select(item => new DocumentModel.Packaging.DiagramDataPartImpl(item)).ToList();
          _DiagramDataParts = new ObservableCollection<DocumentModel.Packaging.DiagramDataPart>(items);
        }
        else
          _DiagramDataParts = new ObservableCollection<DocumentModel.Packaging.DiagramDataPart>();
        _DiagramDataParts.CollectionChanged += _DiagramDataParts_CollectionChanged;
      }
      return _DiagramDataParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.DiagramDataPart>? _DiagramDataParts;
  
  private void _DiagramDataParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramDataPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.DiagramDataPartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.DiagramDataPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramDataPart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts
  {
    get
    {
      if (_DiagramLayoutDefinitionParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart>()
            .Select(item => new DocumentModel.Packaging.DiagramLayoutDefinitionPartImpl(item)).ToList();
          _DiagramLayoutDefinitionParts = new ObservableCollection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>(items);
        }
        else
          _DiagramLayoutDefinitionParts = new ObservableCollection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>();
        _DiagramLayoutDefinitionParts.CollectionChanged += _DiagramLayoutDefinitionParts_CollectionChanged;
      }
      return _DiagramLayoutDefinitionParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>? _DiagramLayoutDefinitionParts;
  
  private void _DiagramLayoutDefinitionParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.DiagramLayoutDefinitionPartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.DiagramLayoutDefinitionPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramPersistLayoutPart>? DiagramPersistLayoutParts
  {
    get
    {
      if (_DiagramPersistLayoutParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart>()
            .Select(item => new DocumentModel.Packaging.DiagramPersistLayoutPartImpl(item)).ToList();
          _DiagramPersistLayoutParts = new ObservableCollection<DocumentModel.Packaging.DiagramPersistLayoutPart>(items);
        }
        else
          _DiagramPersistLayoutParts = new ObservableCollection<DocumentModel.Packaging.DiagramPersistLayoutPart>();
        _DiagramPersistLayoutParts.CollectionChanged += _DiagramPersistLayoutParts_CollectionChanged;
      }
      return _DiagramPersistLayoutParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.DiagramPersistLayoutPart>? _DiagramPersistLayoutParts;
  
  private void _DiagramPersistLayoutParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.DiagramPersistLayoutPartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.DiagramPersistLayoutPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets the DiagramStyleParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramStylePart>? DiagramStyleParts
  {
    get
    {
      if (_DiagramStyleParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramStylePart>()
            .Select(item => new DocumentModel.Packaging.DiagramStylePartImpl(item)).ToList();
          _DiagramStyleParts = new ObservableCollection<DocumentModel.Packaging.DiagramStylePart>(items);
        }
        else
          _DiagramStyleParts = new ObservableCollection<DocumentModel.Packaging.DiagramStylePart>();
        _DiagramStyleParts.CollectionChanged += _DiagramStyleParts_CollectionChanged;
      }
      return _DiagramStyleParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.DiagramStylePart>? _DiagramStyleParts;
  
  private void _DiagramStyleParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramStylePart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.DiagramStylePartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.DiagramStylePartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramStylePart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts
  {
    get
    {
      if (_EmbeddedControlPersistenceBinaryDataParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart>()
            .Select(item => new DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPartImpl(item)).ToList();
          _EmbeddedControlPersistenceBinaryDataParts = new ObservableCollection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>(items);
        }
        else
          _EmbeddedControlPersistenceBinaryDataParts = new ObservableCollection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>();
        _EmbeddedControlPersistenceBinaryDataParts.CollectionChanged += _EmbeddedControlPersistenceBinaryDataParts_CollectionChanged;
      }
      return _EmbeddedControlPersistenceBinaryDataParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>? _EmbeddedControlPersistenceBinaryDataParts;
  
  private void _EmbeddedControlPersistenceBinaryDataParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts
  {
    get
    {
      if (_EmbeddedControlPersistenceParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart>()
            .Select(item => new DocumentModel.Packaging.EmbeddedControlPersistencePartImpl(item)).ToList();
          _EmbeddedControlPersistenceParts = new ObservableCollection<DocumentModel.Packaging.EmbeddedControlPersistencePart>(items);
        }
        else
          _EmbeddedControlPersistenceParts = new ObservableCollection<DocumentModel.Packaging.EmbeddedControlPersistencePart>();
        _EmbeddedControlPersistenceParts.CollectionChanged += _EmbeddedControlPersistenceParts_CollectionChanged;
      }
      return _EmbeddedControlPersistenceParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.EmbeddedControlPersistencePart>? _EmbeddedControlPersistenceParts;
  
  private void _EmbeddedControlPersistenceParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.EmbeddedControlPersistencePartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.EmbeddedControlPersistencePartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedObjectPart>? EmbeddedObjectParts
  {
    get
    {
      if (_EmbeddedObjectParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedObjectPart>()
            .Select(item => new DocumentModel.Packaging.EmbeddedObjectPartImpl(item)).ToList();
          _EmbeddedObjectParts = new ObservableCollection<DocumentModel.Packaging.EmbeddedObjectPart>(items);
        }
        else
          _EmbeddedObjectParts = new ObservableCollection<DocumentModel.Packaging.EmbeddedObjectPart>();
        _EmbeddedObjectParts.CollectionChanged += _EmbeddedObjectParts_CollectionChanged;
      }
      return _EmbeddedObjectParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.EmbeddedObjectPart>? _EmbeddedObjectParts;
  
  private void _EmbeddedObjectParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedObjectPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.EmbeddedObjectPartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.EmbeddedObjectPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedObjectPart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedPackagePart>? EmbeddedPackageParts
  {
    get
    {
      if (_EmbeddedPackageParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedPackagePart>()
            .Select(item => new DocumentModel.Packaging.EmbeddedPackagePartImpl(item)).ToList();
          _EmbeddedPackageParts = new ObservableCollection<DocumentModel.Packaging.EmbeddedPackagePart>(items);
        }
        else
          _EmbeddedPackageParts = new ObservableCollection<DocumentModel.Packaging.EmbeddedPackagePart>();
        _EmbeddedPackageParts.CollectionChanged += _EmbeddedPackageParts_CollectionChanged;
      }
      return _EmbeddedPackageParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.EmbeddedPackagePart>? _EmbeddedPackageParts;
  
  private void _EmbeddedPackageParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedPackagePart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.EmbeddedPackagePartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.EmbeddedPackagePartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedPackagePart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets the ExtendedChartParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.ExtendedChartPart>? ExtendedChartParts
  {
    get
    {
      if (_ExtendedChartParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ExtendedChartPart>()
            .Select(item => new DocumentModel.Packaging.ExtendedChartPartImpl(item)).ToList();
          _ExtendedChartParts = new ObservableCollection<DocumentModel.Packaging.ExtendedChartPart>(items);
        }
        else
          _ExtendedChartParts = new ObservableCollection<DocumentModel.Packaging.ExtendedChartPart>();
        _ExtendedChartParts.CollectionChanged += _ExtendedChartParts_CollectionChanged;
      }
      return _ExtendedChartParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.ExtendedChartPart>? _ExtendedChartParts;
  
  private void _ExtendedChartParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ExtendedChartPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.ExtendedChartPartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.ExtendedChartPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ExtendedChartPart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets the ImageParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts
  {
    get
    {
      if (_ImageParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ImagePart>()
            .Select(item => new DocumentModel.Packaging.ImagePartImpl(item)).ToList();
          _ImageParts = new ObservableCollection<DocumentModel.Packaging.ImagePart>(items);
        }
        else
          _ImageParts = new ObservableCollection<DocumentModel.Packaging.ImagePart>();
        _ImageParts.CollectionChanged += _ImageParts_CollectionChanged;
      }
      return _ImageParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.ImagePart>? _ImageParts;
  
  private void _ImageParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ImagePart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.ImagePartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.ImagePartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ImagePart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts
  {
    get
    {
      if (_Model3DReferenceRelationshipParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart>()
            .Select(item => new DocumentModel.Packaging.Model3DReferenceRelationshipPartImpl(item)).ToList();
          _Model3DReferenceRelationshipParts = new ObservableCollection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>(items);
        }
        else
          _Model3DReferenceRelationshipParts = new ObservableCollection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>();
        _Model3DReferenceRelationshipParts.CollectionChanged += _Model3DReferenceRelationshipParts_CollectionChanged;
      }
      return _Model3DReferenceRelationshipParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>? _Model3DReferenceRelationshipParts;
  
  private void _Model3DReferenceRelationshipParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.Model3DReferenceRelationshipPartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.Model3DReferenceRelationshipPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets the NotesSlidePart of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.NotesSlidePart? NotesSlidePart
  {
    get
    {
      if (OpenXmlElement?.NotesSlidePart != null)
        return new DocumentModel.Packaging.NotesSlidePartImpl(OpenXmlElement.NotesSlidePart);
      return null;
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets the SlideCommentsPart of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.SlideCommentsPart? SlideCommentsPart
  {
    get
    {
      if (OpenXmlElement?.SlideCommentsPart != null)
        return new DocumentModel.Packaging.SlideCommentsPartImpl(OpenXmlElement.SlideCommentsPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the SlideLayoutPart of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.SlideLayoutPart? SlideLayoutPart
  {
    get
    {
      if (OpenXmlElement?.SlideLayoutPart != null)
        return new DocumentModel.Packaging.SlideLayoutPartImpl(OpenXmlElement.SlideLayoutPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the SlideParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.SlidePart>? SlideParts
  {
    get
    {
      if (_SlideParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.SlidePart>()
            .Select(item => new DocumentModel.Packaging.SlidePartImpl(item)).ToList();
          _SlideParts = new ObservableCollection<DocumentModel.Packaging.SlidePart>(items);
        }
        else
          _SlideParts = new ObservableCollection<DocumentModel.Packaging.SlidePart>();
        _SlideParts.CollectionChanged += _SlideParts_CollectionChanged;
      }
      return _SlideParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.SlidePart>? _SlideParts;
  
  private void _SlideParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.SlidePart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.SlidePartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.SlidePartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.SlidePart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets the SlideSyncDataPart of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.SlideSyncDataPart? SlideSyncDataPart
  {
    get
    {
      if (OpenXmlElement?.SlideSyncDataPart != null)
        return new DocumentModel.Packaging.SlideSyncDataPartImpl(OpenXmlElement.SlideSyncDataPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the ThemeOverridePart of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.ThemeOverridePart? ThemeOverridePart
  {
    get
    {
      if (OpenXmlElement?.ThemeOverridePart != null)
        return new DocumentModel.Packaging.ThemeOverridePartImpl(OpenXmlElement.ThemeOverridePart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the UserDefinedTagsParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.UserDefinedTagsPart>? UserDefinedTagsParts
  {
    get
    {
      if (_UserDefinedTagsParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.UserDefinedTagsPart>()
            .Select(item => new DocumentModel.Packaging.UserDefinedTagsPartImpl(item)).ToList();
          _UserDefinedTagsParts = new ObservableCollection<DocumentModel.Packaging.UserDefinedTagsPart>(items);
        }
        else
          _UserDefinedTagsParts = new ObservableCollection<DocumentModel.Packaging.UserDefinedTagsPart>();
        _UserDefinedTagsParts.CollectionChanged += _UserDefinedTagsParts_CollectionChanged;
      }
      return _UserDefinedTagsParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.UserDefinedTagsPart>? _UserDefinedTagsParts;
  
  private void _UserDefinedTagsParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.UserDefinedTagsPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.UserDefinedTagsPartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.UserDefinedTagsPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.UserDefinedTagsPart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets the VmlDrawingParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.VmlDrawingPart>? VmlDrawingParts
  {
    get
    {
      if (_VmlDrawingParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.VmlDrawingPart>()
            .Select(item => new DocumentModel.Packaging.VmlDrawingPartImpl(item)).ToList();
          _VmlDrawingParts = new ObservableCollection<DocumentModel.Packaging.VmlDrawingPart>(items);
        }
        else
          _VmlDrawingParts = new ObservableCollection<DocumentModel.Packaging.VmlDrawingPart>();
        _VmlDrawingParts.CollectionChanged += _VmlDrawingParts_CollectionChanged;
      }
      return _VmlDrawingParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.VmlDrawingPart>? _VmlDrawingParts;
  
  private void _VmlDrawingParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.VmlDrawingPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.VmlDrawingPartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.VmlDrawingPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.VmlDrawingPart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets the WebExtensionParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.WebExtensionPart>? WebExtensionParts
  {
    get
    {
      if (_WebExtensionParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WebExtensionPart>()
            .Select(item => new DocumentModel.Packaging.WebExtensionPartImpl(item)).ToList();
          _WebExtensionParts = new ObservableCollection<DocumentModel.Packaging.WebExtensionPart>(items);
        }
        else
          _WebExtensionParts = new ObservableCollection<DocumentModel.Packaging.WebExtensionPart>();
        _WebExtensionParts.CollectionChanged += _WebExtensionParts_CollectionChanged;
      }
      return _WebExtensionParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.WebExtensionPart>? _WebExtensionParts;
  
  private void _WebExtensionParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WebExtensionPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.WebExtensionPartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.WebExtensionPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WebExtensionPart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
}
