namespace DocumentModel.WebExtensions;

/// <summary>
/// Defines the WebExtensionPropertyBag Class.
/// </summary>
public partial class WebExtensionPropertyBagImpl: ModelElementImpl, WebExtensionPropertyBag
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public WebExtensionPropertyBagImpl(): base() {}
  
  public WebExtensionPropertyBagImpl(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.WebExtensions.WebExtensionProperty>? WebExtensionProperties
  {
    get
    {
      if (_WebExtensionProperties == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty>()
            .Select(item => new DocumentModel.WebExtensions.WebExtensionPropertyImpl(item)).ToList();
          _WebExtensionProperties = new ObservableCollection<DocumentModel.WebExtensions.WebExtensionProperty>(items);
        }
        else
          _WebExtensionProperties = new ObservableCollection<DocumentModel.WebExtensions.WebExtensionProperty>();
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
          if (val is DocumentModel.WebExtensions.WebExtensionPropertyImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.WebExtensions.WebExtensionProperty> observableCollection)
        _WebExtensionProperties = observableCollection;
      else if (value != null)
        _WebExtensionProperties = new ObservableCollection<DocumentModel.WebExtensions.WebExtensionProperty>(value);
      else
       _WebExtensionProperties = null;
    }
  }
  private ObservableCollection<DocumentModel.WebExtensions.WebExtensionProperty>? _WebExtensionProperties;
  
  private void _WebExtensionProperties_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.WebExtensions.WebExtensionPropertyImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddChild(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.WebExtensions.WebExtensionPropertyImpl valImpl)
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
