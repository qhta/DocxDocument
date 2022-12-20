namespace DocumentModel.Packaging;

/// <summary>
/// Defines the HeaderPart
/// </summary>
public partial class HeaderPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, HeaderPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.HeaderPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.HeaderPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public HeaderPartImpl(): base() {}
  
  public HeaderPartImpl(DocumentFormat.OpenXml.Packaging.HeaderPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the HeaderPart
  /// </summary>
  public Collection<DocumentModel.Packaging.AlternativeFormatImportPart>? AlternativeFormatImportParts
  {
    get
    {
      if (_AlternativeFormatImportParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart>()
            .Select(item => new DocumentModel.Packaging.AlternativeFormatImportPartImpl(item)).ToList();
          _AlternativeFormatImportParts = new ObservableCollection<DocumentModel.Packaging.AlternativeFormatImportPart>(items);
        }
        else
          _AlternativeFormatImportParts = new ObservableCollection<DocumentModel.Packaging.AlternativeFormatImportPart>();
        _AlternativeFormatImportParts.CollectionChanged += _AlternativeFormatImportParts_CollectionChanged;
      }
      return _AlternativeFormatImportParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.AlternativeFormatImportPart>? _AlternativeFormatImportParts;
  
  private void _AlternativeFormatImportParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.AlternativeFormatImportPartImpl valImpl)
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
              if (val is DocumentModel.Packaging.AlternativeFormatImportPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart>()
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
  /// Gets the ChartParts of the HeaderPart
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
  
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the HeaderPart
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
  /// Gets the DiagramDataParts of the HeaderPart
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
  /// Gets the DiagramLayoutDefinitionParts of the HeaderPart
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
  /// Gets the DiagramPersistLayoutParts of the HeaderPart
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
  /// Gets the DiagramStyleParts of the HeaderPart
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
  /// Gets the EmbeddedControlPersistenceParts of the HeaderPart
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
  /// Gets the EmbeddedObjectParts of the HeaderPart
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
  /// Gets the EmbeddedPackageParts of the HeaderPart
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
  /// Gets the ExtendedChartParts of the HeaderPart
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
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Header? Header
  {
    get
    {
      if (OpenXmlElement?.Header != null)
        return new DocumentModel.Wordprocessing.HeaderImpl(OpenXmlElement.Header);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Wordprocessing.HeaderImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.Header = valueImpl.OpenXmlElement;
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the HeaderPart
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
  /// Gets the Model3DReferenceRelationshipParts of the HeaderPart
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
  
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
