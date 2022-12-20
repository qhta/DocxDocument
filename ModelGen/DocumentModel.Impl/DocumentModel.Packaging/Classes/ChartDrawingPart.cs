namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartDrawingPart
/// </summary>
public partial class ChartDrawingPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ChartDrawingPart
{
  public new DocumentFormat.OpenXml.Packaging.ChartDrawingPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ChartDrawingPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ChartDrawingPartImpl(): base() {}
  
  public ChartDrawingPartImpl(DocumentFormat.OpenXml.Packaging.ChartDrawingPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the ChartPart of the ChartDrawingPart
  /// </summary>
  public DocumentModel.Packaging.ChartPart? ChartPart
  {
    get
    {
      if (OpenXmlElement?.ChartPart != null)
        return new DocumentModel.Packaging.ChartPartImpl(OpenXmlElement.ChartPart);
      return null;
    }
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the ExtendedChartPart of the ChartDrawingPart
  /// </summary>
  public DocumentModel.Packaging.ExtendedChartPart? ExtendedChartPart
  {
    get
    {
      if (OpenXmlElement?.ExtendedChartPart != null)
        return new DocumentModel.Packaging.ExtendedChartPartImpl(OpenXmlElement.ExtendedChartPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the ChartDrawingPart
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
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Charts.UserShapes? UserShapes
  {
    get
    {
      if (OpenXmlElement?.UserShapes != null)
        return new DocumentModel.Drawings.Charts.UserShapesImpl(OpenXmlElement.UserShapes);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Drawings.Charts.UserShapesImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.UserShapes = valueImpl.OpenXmlElement;
    }
  }
  
}
