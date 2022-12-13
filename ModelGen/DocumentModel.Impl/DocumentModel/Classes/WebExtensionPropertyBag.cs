namespace DocumentModel;

/// <summary>
/// Defines the WebExtensionPropertyBag Class.
/// </summary>
public class WebExtensionPropertyBagImpl: ModelElementImpl, WebExtensionPropertyBag
{
  public DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WebExtensionPropertyBagImpl(): base() {}
  
  public WebExtensionPropertyBagImpl(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.WebExtensionProperty>? WebExtensionProperties
  {
    get
    {
      if (_WebExtensionProperties != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty>()
            .Select(item => new DocumentModel.WebExtensionPropertyImpl(item)).ToList();
          _WebExtensionProperties = new ObservableCollection<DocumentModel.WebExtensionProperty>(items);
        }
        else
          _WebExtensionProperties = new ObservableCollection<DocumentModel.WebExtensionProperty>();
        _WebExtensionProperties.CollectionChanged += _WebExtensionProperties_CollectionChanged;
      }
      return _WebExtensionProperties;
    }
    set
    {
      if (value != null && value != _WebExtensionProperties && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty>();
        foreach (var val in value)
        {
        if (val is DocumentModel.WebExtensionPropertyImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.WebExtensionProperty> observableCollection)
        _WebExtensionProperties = observableCollection;
      else if (value != null)
        _WebExtensionProperties = new ObservableCollection<DocumentModel.WebExtensionProperty>(value);
      else
       _WebExtensionProperties = null;
    }
  }
  private ObservableCollection<DocumentModel.WebExtensionProperty>? _WebExtensionProperties;
  
  private void _WebExtensionProperties_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.WebExtensionPropertyImpl valImpl)
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
        if (val is DocumentModel.WebExtensionPropertyImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty>()
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
