namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom XML Element Properties.
/// </summary>
public class CustomXmlPropertiesImpl: ModelElementImpl, CustomXmlProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CustomXmlPropertiesImpl(): base() {}
  
  public CustomXmlPropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Custom XML Element Placeholder Text.
  /// </summary>
  public String? CustomXmlPlaceholder
  {
    get => (System.String?)OpenXmlElement?.CustomXmlPlaceholder?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.CustomXmlPlaceholder != null)
        {
          if (value is not null)
            OpenXmlElement.CustomXmlPlaceholder.Val = (System.String?)value;
          else
            OpenXmlElement.CustomXmlPlaceholder = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.CustomXmlPlaceholder = new DocumentFormat.OpenXml.Wordprocessing.CustomXmlPlaceholder{ Val = (System.String?)value };
        }
      }
    }
  }
  
  public Collection<DocumentModel.Wordprocessing.CustomXmlAttribute>? CustomXmlAttributes
  {
    get
    {
      if (_CustomXmlAttributes != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute>()
            .Select(item => new DocumentModel.Wordprocessing.CustomXmlAttributeImpl(item)).ToList();
          _CustomXmlAttributes = new ObservableCollection<DocumentModel.Wordprocessing.CustomXmlAttribute>(items);
        }
        else
          _CustomXmlAttributes = new ObservableCollection<DocumentModel.Wordprocessing.CustomXmlAttribute>();
        _CustomXmlAttributes.CollectionChanged += _CustomXmlAttributes_CollectionChanged;
      }
      return _CustomXmlAttributes;
    }
    set
    {
      if (value != null && value != _CustomXmlAttributes && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.CustomXmlAttributeImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.CustomXmlAttribute> observableCollection)
        _CustomXmlAttributes = observableCollection;
      else if (value != null)
        _CustomXmlAttributes = new ObservableCollection<DocumentModel.Wordprocessing.CustomXmlAttribute>(value);
      else
       _CustomXmlAttributes = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.CustomXmlAttribute>? _CustomXmlAttributes;
  
  private void _CustomXmlAttributes_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.CustomXmlAttributeImpl valImpl)
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
        if (val is DocumentModel.Wordprocessing.CustomXmlAttributeImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute>()
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
