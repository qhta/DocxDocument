namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramPersistLayoutPart
/// </summary>
public partial class DiagramPersistLayoutPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, DiagramPersistLayoutPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DiagramPersistLayoutPartImpl(): base() {}
  
  public DiagramPersistLayoutPartImpl(DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart openXmlElement): base(openXmlElement)
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
  public DocumentModel.Drawings.Office.Drawing? Drawing
  {
    get
    {
      if (OpenXmlElement?.Drawing != null)
        return new DocumentModel.Drawings.Office.DrawingImpl(OpenXmlElement.Drawing);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Drawings.Office.DrawingImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.Drawing = valueImpl.OpenXmlElement;
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramPersistLayoutPart
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
  
}
