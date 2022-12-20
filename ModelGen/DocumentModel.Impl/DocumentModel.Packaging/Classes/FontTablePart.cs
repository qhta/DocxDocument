namespace DocumentModel.Packaging;

/// <summary>
/// Defines the FontTablePart
/// </summary>
public partial class FontTablePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, FontTablePart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.FontTablePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.FontTablePart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public FontTablePartImpl(): base() {}
  
  public FontTablePartImpl(DocumentFormat.OpenXml.Packaging.FontTablePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the FontParts of the FontTablePart
  /// </summary>
  public Collection<DocumentModel.Packaging.FontPart>? FontParts
  {
    get
    {
      if (_FontParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.FontPart>()
            .Select(item => new DocumentModel.Packaging.FontPartImpl(item)).ToList();
          _FontParts = new ObservableCollection<DocumentModel.Packaging.FontPart>(items);
        }
        else
          _FontParts = new ObservableCollection<DocumentModel.Packaging.FontPart>();
        _FontParts.CollectionChanged += _FontParts_CollectionChanged;
      }
      return _FontParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.FontPart>? _FontParts;
  
  private void _FontParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.FontPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.FontPartImpl valImpl)
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
              if (val is DocumentModel.Packaging.FontPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.FontPart>()
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
  public DocumentModel.Wordprocessing.Fonts? Fonts
  {
    get
    {
      if (OpenXmlElement?.Fonts != null)
        return new DocumentModel.Wordprocessing.FontsImpl(OpenXmlElement.Fonts);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Wordprocessing.FontsImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.Fonts = valueImpl.OpenXmlElement;
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
