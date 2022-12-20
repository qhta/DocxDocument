namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartPart
/// </summary>
public partial class ChartPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ChartPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.ChartPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ChartPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ChartPartImpl(): base() {}
  
  public ChartPartImpl(DocumentFormat.OpenXml.Packaging.ChartPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the ChartColorStyleParts of the ChartPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartColorStylePart>? ChartColorStyleParts
  {
    get
    {
      if (_ChartColorStyleParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ChartColorStylePart>()
            .Select(item => new DocumentModel.Packaging.ChartColorStylePartImpl(item)).ToList();
          _ChartColorStyleParts = new ObservableCollection<DocumentModel.Packaging.ChartColorStylePart>(items);
        }
        else
          _ChartColorStyleParts = new ObservableCollection<DocumentModel.Packaging.ChartColorStylePart>();
        _ChartColorStyleParts.CollectionChanged += _ChartColorStyleParts_CollectionChanged;
      }
      return _ChartColorStyleParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.ChartColorStylePart>? _ChartColorStyleParts;
  
  private void _ChartColorStyleParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ChartColorStylePart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.ChartColorStylePartImpl valImpl)
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
              if (val is DocumentModel.Packaging.ChartColorStylePartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ChartColorStylePart>()
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
  /// Gets the ChartDrawingPart of the ChartPart
  /// </summary>
  public DocumentModel.Packaging.ChartDrawingPart? ChartDrawingPart
  {
    get
    {
      if (OpenXmlElement?.ChartDrawingPart != null)
        return new DocumentModel.Packaging.ChartDrawingPartImpl(OpenXmlElement.ChartDrawingPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartSpace? ChartSpace
  {
    get
    {
      if (OpenXmlElement?.ChartSpace != null)
        return new DocumentModel.Drawings.Charts.ChartSpaceImpl(OpenXmlElement.ChartSpace);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Drawings.Charts.ChartSpaceImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.ChartSpace = valueImpl.OpenXmlElement;
    }
  }
  
  /// <summary>
  /// Gets the ChartStyleParts of the ChartPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartStylePart>? ChartStyleParts
  {
    get
    {
      if (_ChartStyleParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ChartStylePart>()
            .Select(item => new DocumentModel.Packaging.ChartStylePartImpl(item)).ToList();
          _ChartStyleParts = new ObservableCollection<DocumentModel.Packaging.ChartStylePart>(items);
        }
        else
          _ChartStyleParts = new ObservableCollection<DocumentModel.Packaging.ChartStylePart>();
        _ChartStyleParts.CollectionChanged += _ChartStyleParts_CollectionChanged;
      }
      return _ChartStyleParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.ChartStylePart>? _ChartStyleParts;
  
  private void _ChartStyleParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ChartStylePart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.ChartStylePartImpl valImpl)
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
              if (val is DocumentModel.Packaging.ChartStylePartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ChartStylePart>()
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
  /// Gets the EmbeddedPackagePart of the ChartPart
  /// </summary>
  public DocumentModel.Packaging.EmbeddedPackagePart? EmbeddedPackagePart
  {
    get
    {
      if (OpenXmlElement?.EmbeddedPackagePart != null)
        return new DocumentModel.Packaging.EmbeddedPackagePartImpl(OpenXmlElement.EmbeddedPackagePart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the ChartPart
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
  /// Gets the ThemeOverridePart of the ChartPart
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
  
}
