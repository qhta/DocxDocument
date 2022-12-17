namespace DocumentModel.WebExtensions;

/// <summary>
/// Defines the WebExtensionBindingList Class.
/// </summary>
public class WebExtensionBindingListImpl: ModelElementImpl, WebExtensionBindingList
{
  public DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WebExtensionBindingListImpl(): base() {}
  
  public WebExtensionBindingListImpl(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.WebExtensions.WebExtensionBinding>? WebExtensionBindings
  {
    get
    {
      if (_WebExtensionBindings != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBinding>()
            .Select(item => new DocumentModel.WebExtensions.WebExtensionBindingImpl(item)).ToList();
          _WebExtensionBindings = new ObservableCollection<DocumentModel.WebExtensions.WebExtensionBinding>(items);
        }
        else
          _WebExtensionBindings = new ObservableCollection<DocumentModel.WebExtensions.WebExtensionBinding>();
        _WebExtensionBindings.CollectionChanged += _WebExtensionBindings_CollectionChanged;
      }
      return _WebExtensionBindings;
    }
    set
    {
      if (value != null && value != _WebExtensionBindings && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBinding>();
        foreach (var val in value)
        {
          if (val is DocumentModel.WebExtensions.WebExtensionBindingImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.WebExtensions.WebExtensionBinding> observableCollection)
        _WebExtensionBindings = observableCollection;
      else if (value != null)
        _WebExtensionBindings = new ObservableCollection<DocumentModel.WebExtensions.WebExtensionBinding>(value);
      else
       _WebExtensionBindings = null;
    }
  }
  private ObservableCollection<DocumentModel.WebExtensions.WebExtensionBinding>? _WebExtensionBindings;
  
  private void _WebExtensionBindings_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBinding>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.WebExtensions.WebExtensionBindingImpl valImpl)
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
              if (val is DocumentModel.WebExtensions.WebExtensionBindingImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBinding>()
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
