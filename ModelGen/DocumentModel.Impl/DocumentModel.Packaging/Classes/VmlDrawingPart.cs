namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VmlDrawingPart
/// </summary>
public partial class VmlDrawingPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, VmlDrawingPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.VmlDrawingPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.VmlDrawingPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public VmlDrawingPartImpl(): base() {}
  
  public VmlDrawingPartImpl(DocumentFormat.OpenXml.Packaging.VmlDrawingPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the ImageParts of the VmlDrawingPart
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
  /// Gets the LegacyDiagramTextParts of the VmlDrawingPart
  /// </summary>
  public Collection<DocumentModel.Packaging.LegacyDiagramTextPart>? LegacyDiagramTextParts
  {
    get
    {
      if (_LegacyDiagramTextParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.LegacyDiagramTextPart>()
            .Select(item => new DocumentModel.Packaging.LegacyDiagramTextPartImpl(item)).ToList();
          _LegacyDiagramTextParts = new ObservableCollection<DocumentModel.Packaging.LegacyDiagramTextPart>(items);
        }
        else
          _LegacyDiagramTextParts = new ObservableCollection<DocumentModel.Packaging.LegacyDiagramTextPart>();
        _LegacyDiagramTextParts.CollectionChanged += _LegacyDiagramTextParts_CollectionChanged;
      }
      return _LegacyDiagramTextParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.LegacyDiagramTextPart>? _LegacyDiagramTextParts;
  
  private void _LegacyDiagramTextParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.LegacyDiagramTextPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.LegacyDiagramTextPartImpl valImpl)
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
              if (val is DocumentModel.Packaging.LegacyDiagramTextPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.LegacyDiagramTextPart>()
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
