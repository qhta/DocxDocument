namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WebExTaskpanesPart
/// </summary>
public partial class WebExTaskpanesPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WebExTaskpanesPart
{
  public new DocumentFormat.OpenXml.Packaging.WebExTaskpanesPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.WebExTaskpanesPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WebExTaskpanesPartImpl(): base() {}
  
  public WebExTaskpanesPartImpl(DocumentFormat.OpenXml.Packaging.WebExTaskpanesPart openXmlElement): base(openXmlElement)
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
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.WebExtensions.UI.Taskpanes? Taskpanes
  {
    get
    {
      if (OpenXmlElement?.Taskpanes != null)
        return new DocumentModel.WebExtensions.UI.TaskpanesImpl(OpenXmlElement.Taskpanes);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.WebExtensions.UI.TaskpanesImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.Taskpanes = valueImpl.OpenXmlElement;
    }
  }
  
  /// <summary>
  /// Gets the WebExtensionParts of the WebExTaskpanesPart
  /// </summary>
  public Collection<DocumentModel.Packaging.WebExtensionPart>? WebExtensionParts
  {
    get
    {
      if (_WebExtensionParts != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WebExtensionPart>()
            .Select(item => new DocumentModel.Packaging.WebExtensionPartImpl(item)).ToList();
          _WebExtensionParts = new ObservableCollection<DocumentModel.Packaging.WebExtensionPart>(items);
        }
        else
          _WebExtensionParts = new ObservableCollection<DocumentModel.Packaging.WebExtensionPart>();
        _WebExtensionParts.CollectionChanged += _WebExtensionParts_CollectionChanged;
      }
      return _WebExtensionParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.WebExtensionPart>? _WebExtensionParts;
  
  private void _WebExtensionParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WebExtensionPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.WebExtensionPartImpl valImpl)
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
              if (val is DocumentModel.Packaging.WebExtensionPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WebExtensionPart>()
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
