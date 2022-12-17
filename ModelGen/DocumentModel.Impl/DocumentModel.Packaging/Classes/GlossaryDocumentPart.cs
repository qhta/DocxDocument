namespace DocumentModel.Packaging;

/// <summary>
/// Defines the GlossaryDocumentPart
/// </summary>
public class GlossaryDocumentPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, GlossaryDocumentPart
{
  public new DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GlossaryDocumentPartImpl(): base() {}
  
  public GlossaryDocumentPartImpl(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.AlternativeFormatImportPart>? AlternativeFormatImportParts
  {
    get
    {
      if (_AlternativeFormatImportParts != null)
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
    set
    {
      if (value != null && value != _AlternativeFormatImportParts && OpenXmlElement!=null)
      {
        foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart>().ToArray())
          OpenXmlElement.DeletePart(item);
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.AlternativeFormatImportPartImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddPart(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.AlternativeFormatImportPart> observableCollection)
        _AlternativeFormatImportParts = observableCollection;
      else if (value != null)
        _AlternativeFormatImportParts = new ObservableCollection<DocumentModel.Packaging.AlternativeFormatImportPart>(value);
      else
       _AlternativeFormatImportParts = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.AlternativeFormatImportPart>? _AlternativeFormatImportParts;
  
  private void _AlternativeFormatImportParts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
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
  /// Gets the ChartParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartPart>? ChartParts
  {
    get
    {
      if (_ChartParts != null)
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
    set
    {
      if (value != null && value != _ChartParts && OpenXmlElement!=null)
      {
        foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ChartPart>().ToArray())
          OpenXmlElement.DeletePart(item);
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.ChartPartImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddPart(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.ChartPart> observableCollection)
        _ChartParts = observableCollection;
      else if (value != null)
        _ChartParts = new ObservableCollection<DocumentModel.Packaging.ChartPart>(value);
      else
       _ChartParts = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.ChartPart>? _ChartParts;
  
  private void _ChartParts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
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
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramColorsPart>? DiagramColorsParts
  {
    get
    {
      if (_DiagramColorsParts != null)
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
    set
    {
      if (value != null && value != _DiagramColorsParts && OpenXmlElement!=null)
      {
        foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramColorsPart>().ToArray())
          OpenXmlElement.DeletePart(item);
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.DiagramColorsPartImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddPart(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.DiagramColorsPart> observableCollection)
        _DiagramColorsParts = observableCollection;
      else if (value != null)
        _DiagramColorsParts = new ObservableCollection<DocumentModel.Packaging.DiagramColorsPart>(value);
      else
       _DiagramColorsParts = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.DiagramColorsPart>? _DiagramColorsParts;
  
  private void _DiagramColorsParts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
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
  /// Gets the DiagramDataParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramDataPart>? DiagramDataParts
  {
    get
    {
      if (_DiagramDataParts != null)
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
    set
    {
      if (value != null && value != _DiagramDataParts && OpenXmlElement!=null)
      {
        foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramDataPart>().ToArray())
          OpenXmlElement.DeletePart(item);
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.DiagramDataPartImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddPart(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.DiagramDataPart> observableCollection)
        _DiagramDataParts = observableCollection;
      else if (value != null)
        _DiagramDataParts = new ObservableCollection<DocumentModel.Packaging.DiagramDataPart>(value);
      else
       _DiagramDataParts = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.DiagramDataPart>? _DiagramDataParts;
  
  private void _DiagramDataParts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
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
  /// Gets the DiagramLayoutDefinitionParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts
  {
    get
    {
      if (_DiagramLayoutDefinitionParts != null)
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
    set
    {
      if (value != null && value != _DiagramLayoutDefinitionParts && OpenXmlElement!=null)
      {
        foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart>().ToArray())
          OpenXmlElement.DeletePart(item);
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.DiagramLayoutDefinitionPartImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddPart(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.DiagramLayoutDefinitionPart> observableCollection)
        _DiagramLayoutDefinitionParts = observableCollection;
      else if (value != null)
        _DiagramLayoutDefinitionParts = new ObservableCollection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>(value);
      else
       _DiagramLayoutDefinitionParts = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>? _DiagramLayoutDefinitionParts;
  
  private void _DiagramLayoutDefinitionParts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
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
  /// Gets the DiagramPersistLayoutParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramPersistLayoutPart>? DiagramPersistLayoutParts
  {
    get
    {
      if (_DiagramPersistLayoutParts != null)
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
    set
    {
      if (value != null && value != _DiagramPersistLayoutParts && OpenXmlElement!=null)
      {
        foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart>().ToArray())
          OpenXmlElement.DeletePart(item);
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.DiagramPersistLayoutPartImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddPart(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.DiagramPersistLayoutPart> observableCollection)
        _DiagramPersistLayoutParts = observableCollection;
      else if (value != null)
        _DiagramPersistLayoutParts = new ObservableCollection<DocumentModel.Packaging.DiagramPersistLayoutPart>(value);
      else
       _DiagramPersistLayoutParts = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.DiagramPersistLayoutPart>? _DiagramPersistLayoutParts;
  
  private void _DiagramPersistLayoutParts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
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
  /// Gets the DiagramStyleParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramStylePart>? DiagramStyleParts
  {
    get
    {
      if (_DiagramStyleParts != null)
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
    set
    {
      if (value != null && value != _DiagramStyleParts && OpenXmlElement!=null)
      {
        foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.DiagramStylePart>().ToArray())
          OpenXmlElement.DeletePart(item);
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.DiagramStylePartImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddPart(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.DiagramStylePart> observableCollection)
        _DiagramStyleParts = observableCollection;
      else if (value != null)
        _DiagramStyleParts = new ObservableCollection<DocumentModel.Packaging.DiagramStylePart>(value);
      else
       _DiagramStyleParts = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.DiagramStylePart>? _DiagramStyleParts;
  
  private void _DiagramStyleParts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
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
  /// Gets the EmbeddedControlPersistenceParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts
  {
    get
    {
      if (_EmbeddedControlPersistenceParts != null)
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
    set
    {
      if (value != null && value != _EmbeddedControlPersistenceParts && OpenXmlElement!=null)
      {
        foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart>().ToArray())
          OpenXmlElement.DeletePart(item);
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.EmbeddedControlPersistencePartImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddPart(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.EmbeddedControlPersistencePart> observableCollection)
        _EmbeddedControlPersistenceParts = observableCollection;
      else if (value != null)
        _EmbeddedControlPersistenceParts = new ObservableCollection<DocumentModel.Packaging.EmbeddedControlPersistencePart>(value);
      else
       _EmbeddedControlPersistenceParts = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.EmbeddedControlPersistencePart>? _EmbeddedControlPersistenceParts;
  
  private void _EmbeddedControlPersistenceParts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
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
  /// Gets the EmbeddedObjectParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedObjectPart>? EmbeddedObjectParts
  {
    get
    {
      if (_EmbeddedObjectParts != null)
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
    set
    {
      if (value != null && value != _EmbeddedObjectParts && OpenXmlElement!=null)
      {
        foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedObjectPart>().ToArray())
          OpenXmlElement.DeletePart(item);
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.EmbeddedObjectPartImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddPart(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.EmbeddedObjectPart> observableCollection)
        _EmbeddedObjectParts = observableCollection;
      else if (value != null)
        _EmbeddedObjectParts = new ObservableCollection<DocumentModel.Packaging.EmbeddedObjectPart>(value);
      else
       _EmbeddedObjectParts = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.EmbeddedObjectPart>? _EmbeddedObjectParts;
  
  private void _EmbeddedObjectParts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
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
  /// Gets the EmbeddedPackageParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedPackagePart>? EmbeddedPackageParts
  {
    get
    {
      if (_EmbeddedPackageParts != null)
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
    set
    {
      if (value != null && value != _EmbeddedPackageParts && OpenXmlElement!=null)
      {
        foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedPackagePart>().ToArray())
          OpenXmlElement.DeletePart(item);
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.EmbeddedPackagePartImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddPart(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.EmbeddedPackagePart> observableCollection)
        _EmbeddedPackageParts = observableCollection;
      else if (value != null)
        _EmbeddedPackageParts = new ObservableCollection<DocumentModel.Packaging.EmbeddedPackagePart>(value);
      else
       _EmbeddedPackageParts = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.EmbeddedPackagePart>? _EmbeddedPackageParts;
  
  private void _EmbeddedPackageParts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
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
  /// Gets the ExtendedChartParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ExtendedChartPart>? ExtendedChartParts
  {
    get
    {
      if (_ExtendedChartParts != null)
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
    set
    {
      if (value != null && value != _ExtendedChartParts && OpenXmlElement!=null)
      {
        foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ExtendedChartPart>().ToArray())
          OpenXmlElement.DeletePart(item);
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.ExtendedChartPartImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddPart(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.ExtendedChartPart> observableCollection)
        _ExtendedChartParts = observableCollection;
      else if (value != null)
        _ExtendedChartParts = new ObservableCollection<DocumentModel.Packaging.ExtendedChartPart>(value);
      else
       _ExtendedChartParts = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.ExtendedChartPart>? _ExtendedChartParts;
  
  private void _ExtendedChartParts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
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
  /// Gets the FooterParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.FooterPart>? FooterParts
  {
    get
    {
      if (_FooterParts != null)
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
    set
    {
      if (value != null && value != _FooterParts && OpenXmlElement!=null)
      {
        foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.FooterPart>().ToArray())
          OpenXmlElement.DeletePart(item);
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.FooterPartImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddPart(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.FooterPart> observableCollection)
        _FooterParts = observableCollection;
      else if (value != null)
        _FooterParts = new ObservableCollection<DocumentModel.Packaging.FooterPart>(value);
      else
       _FooterParts = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.FooterPart>? _FooterParts;
  
  private void _FooterParts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
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
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.GlossaryDocument? GlossaryDocument
  {
    get
    {
      if (OpenXmlElement?.GlossaryDocument != null)
        return new DocumentModel.Wordprocessing.GlossaryDocumentImpl(OpenXmlElement.GlossaryDocument);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Wordprocessing.GlossaryDocumentImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.GlossaryDocument = valueImpl.OpenXmlElement;
    }
  }
  
  /// <summary>
  /// Gets the HeaderParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.HeaderPart>? HeaderParts
  {
    get
    {
      if (_HeaderParts != null)
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
    set
    {
      if (value != null && value != _HeaderParts && OpenXmlElement!=null)
      {
        foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.HeaderPart>().ToArray())
          OpenXmlElement.DeletePart(item);
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.HeaderPartImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddPart(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.HeaderPart> observableCollection)
        _HeaderParts = observableCollection;
      else if (value != null)
        _HeaderParts = new ObservableCollection<DocumentModel.Packaging.HeaderPart>(value);
      else
       _HeaderParts = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.HeaderPart>? _HeaderParts;
  
  private void _HeaderParts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
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
  /// Gets the ImageParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts
  {
    get
    {
      if (_ImageParts != null)
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
    set
    {
      if (value != null && value != _ImageParts && OpenXmlElement!=null)
      {
        foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ImagePart>().ToArray())
          OpenXmlElement.DeletePart(item);
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.ImagePartImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddPart(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.ImagePart> observableCollection)
        _ImageParts = observableCollection;
      else if (value != null)
        _ImageParts = new ObservableCollection<DocumentModel.Packaging.ImagePart>(value);
      else
       _ImageParts = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.ImagePart>? _ImageParts;
  
  private void _ImageParts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
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
  /// Gets the Model3DReferenceRelationshipParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts
  {
    get
    {
      if (_Model3DReferenceRelationshipParts != null)
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
    set
    {
      if (value != null && value != _Model3DReferenceRelationshipParts && OpenXmlElement!=null)
      {
        foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart>().ToArray())
          OpenXmlElement.DeletePart(item);
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.Model3DReferenceRelationshipPartImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddPart(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.Model3DReferenceRelationshipPart> observableCollection)
        _Model3DReferenceRelationshipParts = observableCollection;
      else if (value != null)
        _Model3DReferenceRelationshipParts = new ObservableCollection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>(value);
      else
       _Model3DReferenceRelationshipParts = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>? _Model3DReferenceRelationshipParts;
  
  private void _Model3DReferenceRelationshipParts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
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
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the WordprocessingPrinterSettingsParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.WordprocessingPrinterSettingsPart>? WordprocessingPrinterSettingsParts
  {
    get
    {
      if (_WordprocessingPrinterSettingsParts != null)
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
    set
    {
      if (value != null && value != _WordprocessingPrinterSettingsParts && OpenXmlElement!=null)
      {
        foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart>().ToArray())
          OpenXmlElement.DeletePart(item);
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.WordprocessingPrinterSettingsPartImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddPart(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.WordprocessingPrinterSettingsPart> observableCollection)
        _WordprocessingPrinterSettingsParts = observableCollection;
      else if (value != null)
        _WordprocessingPrinterSettingsParts = new ObservableCollection<DocumentModel.Packaging.WordprocessingPrinterSettingsPart>(value);
      else
       _WordprocessingPrinterSettingsParts = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.WordprocessingPrinterSettingsPart>? _WordprocessingPrinterSettingsParts;
  
  private void _WordprocessingPrinterSettingsParts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
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
