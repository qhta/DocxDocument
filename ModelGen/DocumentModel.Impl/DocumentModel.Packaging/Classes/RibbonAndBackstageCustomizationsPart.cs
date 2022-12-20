namespace DocumentModel.Packaging;

/// <summary>
/// Defines the RibbonAndBackstageCustomizationsPart
/// </summary>
public partial class RibbonAndBackstageCustomizationsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, RibbonAndBackstageCustomizationsPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.RibbonAndBackstageCustomizationsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.RibbonAndBackstageCustomizationsPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public RibbonAndBackstageCustomizationsPartImpl(): base() {}
  
  public RibbonAndBackstageCustomizationsPartImpl(DocumentFormat.OpenXml.Packaging.RibbonAndBackstageCustomizationsPart openXmlElement): base(openXmlElement)
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
  public DocumentModel.CustomUI? CustomUI
  {
    get
    {
      if (OpenXmlElement?.CustomUI != null)
        return new DocumentModel.CustomUIImpl(OpenXmlElement.CustomUI);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.CustomUIImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.CustomUI = valueImpl.OpenXmlElement;
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the RibbonAndBackstageCustomizationsPart
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
