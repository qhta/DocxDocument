namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DrawingsPart
/// </summary>
public partial class DrawingsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, DrawingsPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.DrawingsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DrawingsPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DrawingsPartImpl(): base() {}
  
  public DrawingsPartImpl(DocumentFormat.OpenXml.Packaging.DrawingsPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the ChartParts of the DrawingsPart
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
  /// Gets the CustomXmlParts of the DrawingsPart
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
  /// Gets the DiagramColorsParts of the DrawingsPart
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
  /// Gets the DiagramDataParts of the DrawingsPart
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
  /// Gets the DiagramLayoutDefinitionParts of the DrawingsPart
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
  /// Gets the DiagramPersistLayoutParts of the DrawingsPart
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
  /// Gets the DiagramStyleParts of the DrawingsPart
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
  /// Gets the ExtendedChartParts of the DrawingsPart
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
  /// Gets the ImageParts of the DrawingsPart
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
  
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets the WebExtensionParts of the DrawingsPart
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
