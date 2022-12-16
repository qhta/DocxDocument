namespace DocumentModel.WebExtensions;

/// <summary>
/// Defines the WebExtensionReferenceList Class.
/// </summary>
public class WebExtensionReferenceListImpl: ModelElementImpl, WebExtensionReferenceList
{
  public DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WebExtensionReferenceListImpl(): base() {}
  
  public WebExtensionReferenceListImpl(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.WebExtensions.WebExtensionStoreReference>? WebExtensionStoreReferences
  {
    get
    {
      if (_WebExtensionStoreReferences != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>()
            .Select(item => new DocumentModel.WebExtensions.WebExtensionStoreReferenceImpl(item)).ToList();
          _WebExtensionStoreReferences = new ObservableCollection<DocumentModel.WebExtensions.WebExtensionStoreReference>(items);
        }
        else
          _WebExtensionStoreReferences = new ObservableCollection<DocumentModel.WebExtensions.WebExtensionStoreReference>();
        _WebExtensionStoreReferences.CollectionChanged += _WebExtensionStoreReferences_CollectionChanged;
      }
      return _WebExtensionStoreReferences;
    }
    set
    {
      if (value != null && value != _WebExtensionStoreReferences && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>();
        foreach (var val in value)
        {
        if (val is DocumentModel.WebExtensions.WebExtensionStoreReferenceImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.WebExtensions.WebExtensionStoreReference> observableCollection)
        _WebExtensionStoreReferences = observableCollection;
      else if (value != null)
        _WebExtensionStoreReferences = new ObservableCollection<DocumentModel.WebExtensions.WebExtensionStoreReference>(value);
      else
       _WebExtensionStoreReferences = null;
    }
  }
  private ObservableCollection<DocumentModel.WebExtensions.WebExtensionStoreReference>? _WebExtensionStoreReferences;
  
  private void _WebExtensionStoreReferences_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.WebExtensions.WebExtensionStoreReferenceImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          foreach (var val in args.OldItems)
          {
        if (val is DocumentModel.WebExtensions.WebExtensionStoreReferenceImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>()
                          .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
            if (oldItem != null)
              oldItem.Remove();
        };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
}
