namespace DocumentModel.Drawings;

/// <summary>
/// Future extensions..
/// </summary>
public class LinePropertiesExtensionListImpl: ModelElementImpl, LinePropertiesExtensionList
{
  public DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LinePropertiesExtensionListImpl(): base() {}
  
  public LinePropertiesExtensionListImpl(DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.LinePropertiesExtension>? LinePropertiesExtensions
  {
    get
    {
      if (_LinePropertiesExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.LinePropertiesExtension>()
            .Select(item => new DocumentModel.Drawings.LinePropertiesExtensionImpl(item)).ToList();
          _LinePropertiesExtensions = new ObservableCollection<DocumentModel.Drawings.LinePropertiesExtension>(items);
        }
        else
          _LinePropertiesExtensions = new ObservableCollection<DocumentModel.Drawings.LinePropertiesExtension>();
        _LinePropertiesExtensions.CollectionChanged += _LinePropertiesExtensions_CollectionChanged;
      }
      return _LinePropertiesExtensions;
    }
    set
    {
      if (value != null && value != _LinePropertiesExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.LinePropertiesExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.LinePropertiesExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.LinePropertiesExtension> observableCollection)
        _LinePropertiesExtensions = observableCollection;
      else if (value != null)
        _LinePropertiesExtensions = new ObservableCollection<DocumentModel.Drawings.LinePropertiesExtension>(value);
      else
       _LinePropertiesExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.LinePropertiesExtension>? _LinePropertiesExtensions;
  
  private void _LinePropertiesExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.LinePropertiesExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.LinePropertiesExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.LinePropertiesExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.LinePropertiesExtension>()
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
