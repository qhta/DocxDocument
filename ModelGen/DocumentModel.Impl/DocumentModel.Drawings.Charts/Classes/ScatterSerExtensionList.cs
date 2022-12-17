namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ScatterSerExtensionList Class.
/// </summary>
public class ScatterSerExtensionListImpl: ModelElementImpl, ScatterSerExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ScatterSerExtensionListImpl(): base() {}
  
  public ScatterSerExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.ScatterSerExtension>? ScatterSerExtensions
  {
    get
    {
      if (_ScatterSerExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.ScatterSerExtensionImpl(item)).ToList();
          _ScatterSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.ScatterSerExtension>(items);
        }
        else
          _ScatterSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.ScatterSerExtension>();
        _ScatterSerExtensions.CollectionChanged += _ScatterSerExtensions_CollectionChanged;
      }
      return _ScatterSerExtensions;
    }
    set
    {
      if (value != null && value != _ScatterSerExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.ScatterSerExtensionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.ScatterSerExtension> observableCollection)
        _ScatterSerExtensions = observableCollection;
      else if (value != null)
        _ScatterSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.ScatterSerExtension>(value);
      else
       _ScatterSerExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.ScatterSerExtension>? _ScatterSerExtensions;
  
  private void _ScatterSerExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.ScatterSerExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.ScatterSerExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension>()
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
