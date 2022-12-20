namespace DocumentModel.WebExtensions;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public partial class OfficeArtExtensionListImpl: ModelElementImpl, OfficeArtExtensionList
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public OfficeArtExtensionListImpl(): base() {}
  
  public OfficeArtExtensionListImpl(DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Extension>? Extensions
  {
    get
    {
      if (_Extensions == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Extension>()
            .Select(item => new DocumentModel.Drawings.ExtensionImpl(item)).ToList();
          _Extensions = new ObservableCollection<DocumentModel.Drawings.Extension>(items);
        }
        else
          _Extensions = new ObservableCollection<DocumentModel.Drawings.Extension>();
        _Extensions.CollectionChanged += _Extensions_CollectionChanged;
      }
      return _Extensions;
    }
    set
    {
      if (value != null && value != _Extensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Extension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.ExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Extension> observableCollection)
        _Extensions = observableCollection;
      else if (value != null)
        _Extensions = new ObservableCollection<DocumentModel.Drawings.Extension>(value);
      else
       _Extensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Extension>? _Extensions;
  
  private void _Extensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Extension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.ExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.ExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Extension>()
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
