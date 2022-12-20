namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramDataPart
/// </summary>
public partial class DiagramDataPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, DiagramDataPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.DiagramDataPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DiagramDataPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DiagramDataPartImpl(): base() {}
  
  public DiagramDataPartImpl(DocumentFormat.OpenXml.Packaging.DiagramDataPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.DataModelRoot? DataModelRoot
  {
    get
    {
      if (OpenXmlElement?.DataModelRoot != null)
        return new DocumentModel.Drawings.Diagrams.DataModelRootImpl(OpenXmlElement.DataModelRoot);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Drawings.Diagrams.DataModelRootImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.DataModelRoot = valueImpl.OpenXmlElement;
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramDataPart
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
  /// Gets the SlideParts of the DiagramDataPart
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
  /// Gets the WorksheetParts of the DiagramDataPart
  /// </summary>
  public Collection<DocumentModel.Packaging.WorksheetPart>? WorksheetParts
  {
    get
    {
      if (_WorksheetParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WorksheetPart>()
            .Select(item => new DocumentModel.Packaging.WorksheetPartImpl(item)).ToList();
          _WorksheetParts = new ObservableCollection<DocumentModel.Packaging.WorksheetPart>(items);
        }
        else
          _WorksheetParts = new ObservableCollection<DocumentModel.Packaging.WorksheetPart>();
        _WorksheetParts.CollectionChanged += _WorksheetParts_CollectionChanged;
      }
      return _WorksheetParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.WorksheetPart>? _WorksheetParts;
  
  private void _WorksheetParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WorksheetPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.WorksheetPartImpl valImpl)
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
              if (val is DocumentModel.Packaging.WorksheetPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WorksheetPart>()
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
