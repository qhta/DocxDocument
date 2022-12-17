namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartDrawingPart
/// </summary>
public class ChartDrawingPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ChartDrawingPart
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
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ChartDrawingPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
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
  
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ChartDrawingPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
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
