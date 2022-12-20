namespace DocumentModel.Packaging;

/// <summary>
/// Defines the MainDocumentPart
/// </summary>
public partial class MainDocumentPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, MainDocumentPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.MainDocumentPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.MainDocumentPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public MainDocumentPartImpl(): base() {}
  
  public MainDocumentPartImpl(DocumentFormat.OpenXml.Packaging.MainDocumentPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the MainDocumentPart
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
  /// Gets the ChartParts of the MainDocumentPart
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
  /// Gets the CustomizationPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.CustomizationPart? CustomizationPart
  {
    get
    {
      if (OpenXmlElement?.CustomizationPart != null)
        return new DocumentModel.Packaging.CustomizationPartImpl(OpenXmlElement.CustomizationPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the CustomXmlParts of the MainDocumentPart
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
  /// Gets the DiagramColorsParts of the MainDocumentPart
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
  /// Gets the DiagramDataParts of the MainDocumentPart
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
  /// Gets the DiagramLayoutDefinitionParts of the MainDocumentPart
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
  /// Gets the DiagramPersistLayoutParts of the MainDocumentPart
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
  /// Gets the DiagramStyleParts of the MainDocumentPart
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
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Document? Document
  {
    get
    {
      if (OpenXmlElement?.Document != null)
        return new DocumentModel.Wordprocessing.DocumentImpl(OpenXmlElement.Document);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Wordprocessing.DocumentImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.Document = valueImpl.OpenXmlElement;
    }
  }
  
  /// <summary>
  /// Gets the DocumentSettingsPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.DocumentSettingsPart? DocumentSettingsPart
  {
    get
    {
      if (OpenXmlElement?.DocumentSettingsPart != null)
        return new DocumentModel.Packaging.DocumentSettingsPartImpl(OpenXmlElement.DocumentSettingsPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the DocumentTasksPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.DocumentTasksPart? DocumentTasksPart
  {
    get
    {
      if (OpenXmlElement?.DocumentTasksPart != null)
        return new DocumentModel.Packaging.DocumentTasksPartImpl(OpenXmlElement.DocumentTasksPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the MainDocumentPart
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
  /// Gets the EmbeddedObjectParts of the MainDocumentPart
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
  /// Gets the EmbeddedPackageParts of the MainDocumentPart
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
  /// Gets the EndnotesPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.EndnotesPart? EndnotesPart
  {
    get
    {
      if (OpenXmlElement?.EndnotesPart != null)
        return new DocumentModel.Packaging.EndnotesPartImpl(OpenXmlElement.EndnotesPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the MainDocumentPart
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
  /// Gets the FontTablePart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.FontTablePart? FontTablePart
  {
    get
    {
      if (OpenXmlElement?.FontTablePart != null)
        return new DocumentModel.Packaging.FontTablePartImpl(OpenXmlElement.FontTablePart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the FooterParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.FooterPart>? FooterParts
  {
    get
    {
      if (_FooterParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.FooterPart>()
            .Select(item => new DocumentModel.Packaging.FooterPartImpl(item)).ToList();
          _FooterParts = new ObservableCollection<DocumentModel.Packaging.FooterPart>(items);
        }
        else
          _FooterParts = new ObservableCollection<DocumentModel.Packaging.FooterPart>();
        _FooterParts.CollectionChanged += _FooterParts_CollectionChanged;
      }
      return _FooterParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.FooterPart>? _FooterParts;
  
  private void _FooterParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.FooterPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.FooterPartImpl valImpl)
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
              if (val is DocumentModel.Packaging.FooterPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.FooterPart>()
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
  /// Gets the FootnotesPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.FootnotesPart? FootnotesPart
  {
    get
    {
      if (OpenXmlElement?.FootnotesPart != null)
        return new DocumentModel.Packaging.FootnotesPartImpl(OpenXmlElement.FootnotesPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the GlossaryDocumentPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.GlossaryDocumentPart? GlossaryDocumentPart
  {
    get
    {
      if (OpenXmlElement?.GlossaryDocumentPart != null)
        return new DocumentModel.Packaging.GlossaryDocumentPartImpl(OpenXmlElement.GlossaryDocumentPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the HeaderParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.HeaderPart>? HeaderParts
  {
    get
    {
      if (_HeaderParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.HeaderPart>()
            .Select(item => new DocumentModel.Packaging.HeaderPartImpl(item)).ToList();
          _HeaderParts = new ObservableCollection<DocumentModel.Packaging.HeaderPart>(items);
        }
        else
          _HeaderParts = new ObservableCollection<DocumentModel.Packaging.HeaderPart>();
        _HeaderParts.CollectionChanged += _HeaderParts_CollectionChanged;
      }
      return _HeaderParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.HeaderPart>? _HeaderParts;
  
  private void _HeaderParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.HeaderPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.HeaderPartImpl valImpl)
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
              if (val is DocumentModel.Packaging.HeaderPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.HeaderPart>()
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
  /// Gets the ImageParts of the MainDocumentPart
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
  /// Gets the Model3DReferenceRelationshipParts of the MainDocumentPart
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
  /// Gets the NumberingDefinitionsPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.NumberingDefinitionsPart? NumberingDefinitionsPart
  {
    get
    {
      if (OpenXmlElement?.NumberingDefinitionsPart != null)
        return new DocumentModel.Packaging.NumberingDefinitionsPartImpl(OpenXmlElement.NumberingDefinitionsPart);
      return null;
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets the StyleDefinitionsPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.StyleDefinitionsPart? StyleDefinitionsPart
  {
    get
    {
      if (OpenXmlElement?.StyleDefinitionsPart != null)
        return new DocumentModel.Packaging.StyleDefinitionsPartImpl(OpenXmlElement.StyleDefinitionsPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the StylesWithEffectsPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.StylesWithEffectsPart? StylesWithEffectsPart
  {
    get
    {
      if (OpenXmlElement?.StylesWithEffectsPart != null)
        return new DocumentModel.Packaging.StylesWithEffectsPartImpl(OpenXmlElement.StylesWithEffectsPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the ThemePart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.ThemePart? ThemePart
  {
    get
    {
      if (OpenXmlElement?.ThemePart != null)
        return new DocumentModel.Packaging.ThemePartImpl(OpenXmlElement.ThemePart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the ThumbnailPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.ThumbnailPart? ThumbnailPart
  {
    get
    {
      if (OpenXmlElement?.ThumbnailPart != null)
        return new DocumentModel.Packaging.ThumbnailPartImpl(OpenXmlElement.ThumbnailPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the VbaProjectPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.VbaProjectPart? VbaProjectPart
  {
    get
    {
      if (OpenXmlElement?.VbaProjectPart != null)
        return new DocumentModel.Packaging.VbaProjectPartImpl(OpenXmlElement.VbaProjectPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the WebSettingsPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.WebSettingsPart? WebSettingsPart
  {
    get
    {
      if (OpenXmlElement?.WebSettingsPart != null)
        return new DocumentModel.Packaging.WebSettingsPartImpl(OpenXmlElement.WebSettingsPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the WordCommentsExtensiblePart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.WordCommentsExtensiblePart? WordCommentsExtensiblePart
  {
    get
    {
      if (OpenXmlElement?.WordCommentsExtensiblePart != null)
        return new DocumentModel.Packaging.WordCommentsExtensiblePartImpl(OpenXmlElement.WordCommentsExtensiblePart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the WordprocessingCommentsExPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.WordprocessingCommentsExPart? WordprocessingCommentsExPart
  {
    get
    {
      if (OpenXmlElement?.WordprocessingCommentsExPart != null)
        return new DocumentModel.Packaging.WordprocessingCommentsExPartImpl(OpenXmlElement.WordprocessingCommentsExPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the WordprocessingCommentsIdsPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.WordprocessingCommentsIdsPart? WordprocessingCommentsIdsPart
  {
    get
    {
      if (OpenXmlElement?.WordprocessingCommentsIdsPart != null)
        return new DocumentModel.Packaging.WordprocessingCommentsIdsPartImpl(OpenXmlElement.WordprocessingCommentsIdsPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the WordprocessingCommentsPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.WordprocessingCommentsPart? WordprocessingCommentsPart
  {
    get
    {
      if (OpenXmlElement?.WordprocessingCommentsPart != null)
        return new DocumentModel.Packaging.WordprocessingCommentsPartImpl(OpenXmlElement.WordprocessingCommentsPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the WordprocessingPeoplePart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.WordprocessingPeoplePart? WordprocessingPeoplePart
  {
    get
    {
      if (OpenXmlElement?.WordprocessingPeoplePart != null)
        return new DocumentModel.Packaging.WordprocessingPeoplePartImpl(OpenXmlElement.WordprocessingPeoplePart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the WordprocessingPrinterSettingsParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.WordprocessingPrinterSettingsPart>? WordprocessingPrinterSettingsParts
  {
    get
    {
      if (_WordprocessingPrinterSettingsParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart>()
            .Select(item => new DocumentModel.Packaging.WordprocessingPrinterSettingsPartImpl(item)).ToList();
          _WordprocessingPrinterSettingsParts = new ObservableCollection<DocumentModel.Packaging.WordprocessingPrinterSettingsPart>(items);
        }
        else
          _WordprocessingPrinterSettingsParts = new ObservableCollection<DocumentModel.Packaging.WordprocessingPrinterSettingsPart>();
        _WordprocessingPrinterSettingsParts.CollectionChanged += _WordprocessingPrinterSettingsParts_CollectionChanged;
      }
      return _WordprocessingPrinterSettingsParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.WordprocessingPrinterSettingsPart>? _WordprocessingPrinterSettingsParts;
  
  private void _WordprocessingPrinterSettingsParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.WordprocessingPrinterSettingsPartImpl valImpl)
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
              if (val is DocumentModel.Packaging.WordprocessingPrinterSettingsPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart>()
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
