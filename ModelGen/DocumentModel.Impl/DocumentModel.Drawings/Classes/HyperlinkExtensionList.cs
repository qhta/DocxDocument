namespace DocumentModel.Drawings;

/// <summary>
/// Future extensions..
/// </summary>
public partial class HyperlinkExtensionListImpl: ModelElementImpl, HyperlinkExtensionList
{
  public DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public HyperlinkExtensionListImpl(): base() {}
  
  public HyperlinkExtensionListImpl(DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.HyperlinkExtension>? HyperlinkExtensions
  {
    get
    {
      if (_HyperlinkExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.HyperlinkExtension>()
            .Select(item => new DocumentModel.Drawings.HyperlinkExtensionImpl(item)).ToList();
          _HyperlinkExtensions = new ObservableCollection<DocumentModel.Drawings.HyperlinkExtension>(items);
        }
        else
          _HyperlinkExtensions = new ObservableCollection<DocumentModel.Drawings.HyperlinkExtension>();
        _HyperlinkExtensions.CollectionChanged += _HyperlinkExtensions_CollectionChanged;
      }
      return _HyperlinkExtensions;
    }
    set
    {
      if (value != null && value != _HyperlinkExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.HyperlinkExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.HyperlinkExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.HyperlinkExtension> observableCollection)
        _HyperlinkExtensions = observableCollection;
      else if (value != null)
        _HyperlinkExtensions = new ObservableCollection<DocumentModel.Drawings.HyperlinkExtension>(value);
      else
       _HyperlinkExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.HyperlinkExtension>? _HyperlinkExtensions;
  
  private void _HyperlinkExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.HyperlinkExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.HyperlinkExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.HyperlinkExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.HyperlinkExtension>()
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
