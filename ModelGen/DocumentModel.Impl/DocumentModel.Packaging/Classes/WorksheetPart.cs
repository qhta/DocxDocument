namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WorksheetPart
/// </summary>
public partial class WorksheetPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WorksheetPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.WorksheetPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.WorksheetPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public WorksheetPartImpl(): base() {}
  
  public WorksheetPartImpl(DocumentFormat.OpenXml.Packaging.WorksheetPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the ControlPropertiesParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ControlPropertiesPart>? ControlPropertiesParts
  {
    get
    {
      if (_ControlPropertiesParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ControlPropertiesPart>()
            .Select(item => new DocumentModel.Packaging.ControlPropertiesPartImpl(item)).ToList();
          _ControlPropertiesParts = new ObservableCollection<DocumentModel.Packaging.ControlPropertiesPart>(items);
        }
        else
          _ControlPropertiesParts = new ObservableCollection<DocumentModel.Packaging.ControlPropertiesPart>();
        _ControlPropertiesParts.CollectionChanged += _ControlPropertiesParts_CollectionChanged;
      }
      return _ControlPropertiesParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.ControlPropertiesPart>? _ControlPropertiesParts;
  
  private void _ControlPropertiesParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ControlPropertiesPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.ControlPropertiesPartImpl valImpl)
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
              if (val is DocumentModel.Packaging.ControlPropertiesPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ControlPropertiesPart>()
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
  /// Gets the CustomPropertyParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.CustomPropertyPart>? CustomPropertyParts
  {
    get
    {
      if (_CustomPropertyParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.CustomPropertyPart>()
            .Select(item => new DocumentModel.Packaging.CustomPropertyPartImpl(item)).ToList();
          _CustomPropertyParts = new ObservableCollection<DocumentModel.Packaging.CustomPropertyPart>(items);
        }
        else
          _CustomPropertyParts = new ObservableCollection<DocumentModel.Packaging.CustomPropertyPart>();
        _CustomPropertyParts.CollectionChanged += _CustomPropertyParts_CollectionChanged;
      }
      return _CustomPropertyParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.CustomPropertyPart>? _CustomPropertyParts;
  
  private void _CustomPropertyParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.CustomPropertyPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.CustomPropertyPartImpl valImpl)
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
              if (val is DocumentModel.Packaging.CustomPropertyPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.CustomPropertyPart>()
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
  /// Gets the DrawingsPart of the WorksheetPart
  /// </summary>
  public DocumentModel.Packaging.DrawingsPart? DrawingsPart
  {
    get
    {
      if (OpenXmlElement?.DrawingsPart != null)
        return new DocumentModel.Packaging.DrawingsPartImpl(OpenXmlElement.DrawingsPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the WorksheetPart
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
  /// Gets the EmbeddedControlPersistenceParts of the WorksheetPart
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
  /// Gets the EmbeddedObjectParts of the WorksheetPart
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
  /// Gets the EmbeddedPackageParts of the WorksheetPart
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
  /// Gets the ImageParts of the WorksheetPart
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
  /// Gets the Model3DReferenceRelationshipParts of the WorksheetPart
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
  /// Gets the NamedSheetViewsParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.NamedSheetViewsPart>? NamedSheetViewsParts
  {
    get
    {
      if (_NamedSheetViewsParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.NamedSheetViewsPart>()
            .Select(item => new DocumentModel.Packaging.NamedSheetViewsPartImpl(item)).ToList();
          _NamedSheetViewsParts = new ObservableCollection<DocumentModel.Packaging.NamedSheetViewsPart>(items);
        }
        else
          _NamedSheetViewsParts = new ObservableCollection<DocumentModel.Packaging.NamedSheetViewsPart>();
        _NamedSheetViewsParts.CollectionChanged += _NamedSheetViewsParts_CollectionChanged;
      }
      return _NamedSheetViewsParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.NamedSheetViewsPart>? _NamedSheetViewsParts;
  
  private void _NamedSheetViewsParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.NamedSheetViewsPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.NamedSheetViewsPartImpl valImpl)
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
              if (val is DocumentModel.Packaging.NamedSheetViewsPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.NamedSheetViewsPart>()
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
  /// Gets the PivotTableParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.PivotTablePart>? PivotTableParts
  {
    get
    {
      if (_PivotTableParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.PivotTablePart>()
            .Select(item => new DocumentModel.Packaging.PivotTablePartImpl(item)).ToList();
          _PivotTableParts = new ObservableCollection<DocumentModel.Packaging.PivotTablePart>(items);
        }
        else
          _PivotTableParts = new ObservableCollection<DocumentModel.Packaging.PivotTablePart>();
        _PivotTableParts.CollectionChanged += _PivotTableParts_CollectionChanged;
      }
      return _PivotTableParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.PivotTablePart>? _PivotTableParts;
  
  private void _PivotTableParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.PivotTablePart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.PivotTablePartImpl valImpl)
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
              if (val is DocumentModel.Packaging.PivotTablePartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.PivotTablePart>()
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
  /// Gets the QueryTableParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.QueryTablePart>? QueryTableParts
  {
    get
    {
      if (_QueryTableParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.QueryTablePart>()
            .Select(item => new DocumentModel.Packaging.QueryTablePartImpl(item)).ToList();
          _QueryTableParts = new ObservableCollection<DocumentModel.Packaging.QueryTablePart>(items);
        }
        else
          _QueryTableParts = new ObservableCollection<DocumentModel.Packaging.QueryTablePart>();
        _QueryTableParts.CollectionChanged += _QueryTableParts_CollectionChanged;
      }
      return _QueryTableParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.QueryTablePart>? _QueryTableParts;
  
  private void _QueryTableParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.QueryTablePart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.QueryTablePartImpl valImpl)
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
              if (val is DocumentModel.Packaging.QueryTablePartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.QueryTablePart>()
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
  /// Gets the SingleCellTablePart of the WorksheetPart
  /// </summary>
  public DocumentModel.Packaging.SingleCellTablePart? SingleCellTablePart
  {
    get
    {
      if (OpenXmlElement?.SingleCellTablePart != null)
        return new DocumentModel.Packaging.SingleCellTablePartImpl(OpenXmlElement.SingleCellTablePart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the SlicersParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.SlicersPart>? SlicersParts
  {
    get
    {
      if (_SlicersParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.SlicersPart>()
            .Select(item => new DocumentModel.Packaging.SlicersPartImpl(item)).ToList();
          _SlicersParts = new ObservableCollection<DocumentModel.Packaging.SlicersPart>(items);
        }
        else
          _SlicersParts = new ObservableCollection<DocumentModel.Packaging.SlicersPart>();
        _SlicersParts.CollectionChanged += _SlicersParts_CollectionChanged;
      }
      return _SlicersParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.SlicersPart>? _SlicersParts;
  
  private void _SlicersParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.SlicersPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.SlicersPartImpl valImpl)
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
              if (val is DocumentModel.Packaging.SlicersPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.SlicersPart>()
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
  /// Gets the SpreadsheetPrinterSettingsParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.SpreadsheetPrinterSettingsPart>? SpreadsheetPrinterSettingsParts
  {
    get
    {
      if (_SpreadsheetPrinterSettingsParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.SpreadsheetPrinterSettingsPart>()
            .Select(item => new DocumentModel.Packaging.SpreadsheetPrinterSettingsPartImpl(item)).ToList();
          _SpreadsheetPrinterSettingsParts = new ObservableCollection<DocumentModel.Packaging.SpreadsheetPrinterSettingsPart>(items);
        }
        else
          _SpreadsheetPrinterSettingsParts = new ObservableCollection<DocumentModel.Packaging.SpreadsheetPrinterSettingsPart>();
        _SpreadsheetPrinterSettingsParts.CollectionChanged += _SpreadsheetPrinterSettingsParts_CollectionChanged;
      }
      return _SpreadsheetPrinterSettingsParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.SpreadsheetPrinterSettingsPart>? _SpreadsheetPrinterSettingsParts;
  
  private void _SpreadsheetPrinterSettingsParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.SpreadsheetPrinterSettingsPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.SpreadsheetPrinterSettingsPartImpl valImpl)
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
              if (val is DocumentModel.Packaging.SpreadsheetPrinterSettingsPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.SpreadsheetPrinterSettingsPart>()
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
  /// Gets the TableDefinitionParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.TableDefinitionPart>? TableDefinitionParts
  {
    get
    {
      if (_TableDefinitionParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.TableDefinitionPart>()
            .Select(item => new DocumentModel.Packaging.TableDefinitionPartImpl(item)).ToList();
          _TableDefinitionParts = new ObservableCollection<DocumentModel.Packaging.TableDefinitionPart>(items);
        }
        else
          _TableDefinitionParts = new ObservableCollection<DocumentModel.Packaging.TableDefinitionPart>();
        _TableDefinitionParts.CollectionChanged += _TableDefinitionParts_CollectionChanged;
      }
      return _TableDefinitionParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.TableDefinitionPart>? _TableDefinitionParts;
  
  private void _TableDefinitionParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.TableDefinitionPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.TableDefinitionPartImpl valImpl)
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
              if (val is DocumentModel.Packaging.TableDefinitionPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.TableDefinitionPart>()
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
  /// Gets the TimeLineParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.TimeLinePart>? TimeLineParts
  {
    get
    {
      if (_TimeLineParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.TimeLinePart>()
            .Select(item => new DocumentModel.Packaging.TimeLinePartImpl(item)).ToList();
          _TimeLineParts = new ObservableCollection<DocumentModel.Packaging.TimeLinePart>(items);
        }
        else
          _TimeLineParts = new ObservableCollection<DocumentModel.Packaging.TimeLinePart>();
        _TimeLineParts.CollectionChanged += _TimeLineParts_CollectionChanged;
      }
      return _TimeLineParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.TimeLinePart>? _TimeLineParts;
  
  private void _TimeLineParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.TimeLinePart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.TimeLinePartImpl valImpl)
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
              if (val is DocumentModel.Packaging.TimeLinePartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.TimeLinePart>()
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
  /// Gets the VmlDrawingParts of the WorksheetPart
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
  /// Gets the WorksheetCommentsPart of the WorksheetPart
  /// </summary>
  public DocumentModel.Packaging.WorksheetCommentsPart? WorksheetCommentsPart
  {
    get
    {
      if (OpenXmlElement?.WorksheetCommentsPart != null)
        return new DocumentModel.Packaging.WorksheetCommentsPartImpl(OpenXmlElement.WorksheetCommentsPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the WorksheetSortMapPart of the WorksheetPart
  /// </summary>
  public DocumentModel.Packaging.WorksheetSortMapPart? WorksheetSortMapPart
  {
    get
    {
      if (OpenXmlElement?.WorksheetSortMapPart != null)
        return new DocumentModel.Packaging.WorksheetSortMapPartImpl(OpenXmlElement.WorksheetSortMapPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the WorksheetThreadedCommentsParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.WorksheetThreadedCommentsPart>? WorksheetThreadedCommentsParts
  {
    get
    {
      if (_WorksheetThreadedCommentsParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WorksheetThreadedCommentsPart>()
            .Select(item => new DocumentModel.Packaging.WorksheetThreadedCommentsPartImpl(item)).ToList();
          _WorksheetThreadedCommentsParts = new ObservableCollection<DocumentModel.Packaging.WorksheetThreadedCommentsPart>(items);
        }
        else
          _WorksheetThreadedCommentsParts = new ObservableCollection<DocumentModel.Packaging.WorksheetThreadedCommentsPart>();
        _WorksheetThreadedCommentsParts.CollectionChanged += _WorksheetThreadedCommentsParts_CollectionChanged;
      }
      return _WorksheetThreadedCommentsParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.WorksheetThreadedCommentsPart>? _WorksheetThreadedCommentsParts;
  
  private void _WorksheetThreadedCommentsParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WorksheetThreadedCommentsPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.WorksheetThreadedCommentsPartImpl valImpl)
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
              if (val is DocumentModel.Packaging.WorksheetThreadedCommentsPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WorksheetThreadedCommentsPart>()
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
