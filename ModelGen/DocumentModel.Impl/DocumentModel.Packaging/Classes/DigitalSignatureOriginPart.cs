namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DigitalSignatureOriginPart
/// </summary>
public partial class DigitalSignatureOriginPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, DigitalSignatureOriginPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.DigitalSignatureOriginPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DigitalSignatureOriginPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DigitalSignatureOriginPartImpl(): base() {}
  
  public DigitalSignatureOriginPartImpl(DocumentFormat.OpenXml.Packaging.DigitalSignatureOriginPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets the XmlSignatureParts of the DigitalSignatureOriginPart
  /// </summary>
  public Collection<DocumentModel.Packaging.XmlSignaturePart>? XmlSignatureParts
  {
    get
    {
      if (_XmlSignatureParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.XmlSignaturePart>()
            .Select(item => new DocumentModel.Packaging.XmlSignaturePartImpl(item)).ToList();
          _XmlSignatureParts = new ObservableCollection<DocumentModel.Packaging.XmlSignaturePart>(items);
        }
        else
          _XmlSignatureParts = new ObservableCollection<DocumentModel.Packaging.XmlSignaturePart>();
        _XmlSignatureParts.CollectionChanged += _XmlSignatureParts_CollectionChanged;
      }
      return _XmlSignatureParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.XmlSignaturePart>? _XmlSignatureParts;
  
  private void _XmlSignatureParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.XmlSignaturePart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.XmlSignaturePartImpl valImpl)
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
              if (val is DocumentModel.Packaging.XmlSignaturePartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.XmlSignaturePart>()
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
