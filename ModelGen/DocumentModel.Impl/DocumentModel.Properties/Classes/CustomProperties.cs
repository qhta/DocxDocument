namespace DocumentModel.Properties;

/// <summary>
/// Custom File Properties.
/// </summary>
public partial class CustomPropertiesImpl: ModelElementImpl, CustomProperties
{
  public DocumentFormat.OpenXml.CustomProperties.Properties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.CustomProperties.Properties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CustomPropertiesImpl(): base() {}
  
  public CustomPropertiesImpl(DocumentFormat.OpenXml.CustomProperties.Properties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the CustomFilePropertiesPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.CustomFilePropertiesPart? CustomFilePropertiesPart
  {
    get
    {
      if (OpenXmlElement?.CustomFilePropertiesPart != null)
        return new DocumentModel.Packaging.CustomFilePropertiesPartImpl(OpenXmlElement.CustomFilePropertiesPart);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
        if (value is DocumentModel.Packaging.CustomFilePropertiesPartImpl valueImpl)
          if (valueImpl.OpenXmlElement != null)
              OpenXmlElement.SetPart(valueImpl.OpenXmlElement);
    }
  }
  
  public Collection<DocumentModel.Properties.CustomDocumentProperty>? CustomDocumentProperties
  {
    get
    {
      if (_CustomDocumentProperties == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty>()
            .Select(item => new DocumentModel.Properties.CustomDocumentPropertyImpl(item)).ToList();
          _CustomDocumentProperties = new ObservableCollection<DocumentModel.Properties.CustomDocumentProperty>(items);
        }
        else
          _CustomDocumentProperties = new ObservableCollection<DocumentModel.Properties.CustomDocumentProperty>();
        _CustomDocumentProperties.CollectionChanged += _CustomDocumentProperties_CollectionChanged;
      }
      return _CustomDocumentProperties;
    }
    set
    {
      if (value != null && value != _CustomDocumentProperties && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Properties.CustomDocumentPropertyImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Properties.CustomDocumentProperty> observableCollection)
        _CustomDocumentProperties = observableCollection;
      else if (value != null)
        _CustomDocumentProperties = new ObservableCollection<DocumentModel.Properties.CustomDocumentProperty>(value);
      else
       _CustomDocumentProperties = null;
    }
  }
  private ObservableCollection<DocumentModel.Properties.CustomDocumentProperty>? _CustomDocumentProperties;
  
  private void _CustomDocumentProperties_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Properties.CustomDocumentPropertyImpl valImpl)
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
              if (val is DocumentModel.Properties.CustomDocumentPropertyImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty>()
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
