namespace DocumentModel.Drawings;

/// <summary>
/// Future extensions..
/// </summary>
public class BlipExtensionListImpl: ModelElementImpl, BlipExtensionList
{
  public DocumentFormat.OpenXml.Drawing.BlipExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.BlipExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BlipExtensionListImpl(): base() {}
  
  public BlipExtensionListImpl(DocumentFormat.OpenXml.Drawing.BlipExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.BlipExtension>? BlipExtensions
  {
    get
    {
      if (_BlipExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.BlipExtension>()
            .Select(item => new DocumentModel.Drawings.BlipExtensionImpl(item)).ToList();
          _BlipExtensions = new ObservableCollection<DocumentModel.Drawings.BlipExtension>(items);
        }
        else
          _BlipExtensions = new ObservableCollection<DocumentModel.Drawings.BlipExtension>();
        _BlipExtensions.CollectionChanged += _BlipExtensions_CollectionChanged;
      }
      return _BlipExtensions;
    }
    set
    {
      if (value != null && value != _BlipExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.BlipExtension>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.BlipExtensionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.BlipExtension> observableCollection)
        _BlipExtensions = observableCollection;
      else if (value != null)
        _BlipExtensions = new ObservableCollection<DocumentModel.Drawings.BlipExtension>(value);
      else
       _BlipExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.BlipExtension>? _BlipExtensions;
  
  private void _BlipExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.BlipExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.BlipExtensionImpl valImpl)
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
        if (val is DocumentModel.Drawings.BlipExtensionImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.BlipExtension>()
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
