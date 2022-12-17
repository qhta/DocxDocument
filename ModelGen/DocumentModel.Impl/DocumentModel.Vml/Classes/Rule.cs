namespace DocumentModel.Vml;

/// <summary>
/// Rule.
/// </summary>
public class RuleImpl: ModelElementImpl, Rule
{
  public DocumentFormat.OpenXml.Vml.Office.Rule? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.Rule?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RuleImpl(): base() {}
  
  public RuleImpl(DocumentFormat.OpenXml.Vml.Office.Rule openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Rule ID
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Rule Type
  /// </summary>
  public DocumentModel.Vml.RuleKind? Type
  {
    get => (DocumentModel.Vml.RuleKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Vml.Office.RuleValues?)value;
    }
  }
  
  /// <summary>
  /// Alignment Rule Type
  /// </summary>
  public DocumentModel.Vml.AlignmentKind? How
  {
    get => (DocumentModel.Vml.AlignmentKind?)OpenXmlElement?.How?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.How = (DocumentFormat.OpenXml.Vml.Office.AlignmentValues?)value;
    }
  }
  
  /// <summary>
  /// Rule Shape Reference
  /// </summary>
  public String? ShapeReference
  {
    get => (System.String?)OpenXmlElement?.ShapeReference?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShapeReference = (System.String?)value;
    }
  }
  
  public Collection<DocumentModel.Vml.Proxy>? Proxies
  {
    get
    {
      if (_Proxies != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Vml.Office.Proxy>()
            .Select(item => new DocumentModel.Vml.ProxyImpl(item)).ToList();
          _Proxies = new ObservableCollection<DocumentModel.Vml.Proxy>(items);
        }
        else
          _Proxies = new ObservableCollection<DocumentModel.Vml.Proxy>();
        _Proxies.CollectionChanged += _Proxies_CollectionChanged;
      }
      return _Proxies;
    }
    set
    {
      if (value != null && value != _Proxies && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Office.Proxy>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Vml.ProxyImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Vml.Proxy> observableCollection)
        _Proxies = observableCollection;
      else if (value != null)
        _Proxies = new ObservableCollection<DocumentModel.Vml.Proxy>(value);
      else
       _Proxies = null;
    }
  }
  private ObservableCollection<DocumentModel.Vml.Proxy>? _Proxies;
  
  private void _Proxies_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Office.Proxy>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Vml.ProxyImpl valImpl)
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
              if (val is DocumentModel.Vml.ProxyImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Vml.Office.Proxy>()
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
