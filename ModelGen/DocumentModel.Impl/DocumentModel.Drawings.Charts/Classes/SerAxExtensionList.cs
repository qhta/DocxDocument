namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the SerAxExtensionList Class.
/// </summary>
public class SerAxExtensionListImpl: ModelElementImpl, SerAxExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.SerAxExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SerAxExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SerAxExtensionListImpl(): base() {}
  
  public SerAxExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.SerAxExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.SerAxExtension>? SerAxExtensions
  {
    get
    {
      if (_SerAxExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.SerAxExtensionImpl(item)).ToList();
          _SerAxExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.SerAxExtension>(items);
        }
        else
          _SerAxExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.SerAxExtension>();
        _SerAxExtensions.CollectionChanged += _SerAxExtensions_CollectionChanged;
      }
      return _SerAxExtensions;
    }
    set
    {
      if (value != null && value != _SerAxExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.SerAxExtensionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.SerAxExtension> observableCollection)
        _SerAxExtensions = observableCollection;
      else if (value != null)
        _SerAxExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.SerAxExtension>(value);
      else
       _SerAxExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.SerAxExtension>? _SerAxExtensions;
  
  private void _SerAxExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.SerAxExtensionImpl valImpl)
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
        if (val is DocumentModel.Drawings.Charts.SerAxExtensionImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension>()
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
