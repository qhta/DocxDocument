namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DLblsExtensionList Class.
/// </summary>
public partial class DLblsExtensionListImpl: ModelElementImpl, DLblsExtensionList
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.DLblsExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DLblsExtensionList?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DLblsExtensionListImpl(): base() {}
  
  public DLblsExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.DLblsExtension>? DLblsExtensions
  {
    get
    {
      if (_DLblsExtensions == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.DLblsExtensionImpl(item)).ToList();
          _DLblsExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.DLblsExtension>(items);
        }
        else
          _DLblsExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.DLblsExtension>();
        _DLblsExtensions.CollectionChanged += _DLblsExtensions_CollectionChanged;
      }
      return _DLblsExtensions;
    }
    set
    {
      if (value != null && value != _DLblsExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.DLblsExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.DLblsExtension> observableCollection)
        _DLblsExtensions = observableCollection;
      else if (value != null)
        _DLblsExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.DLblsExtension>(value);
      else
       _DLblsExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.DLblsExtension>? _DLblsExtensions;
  
  private void _DLblsExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.DLblsExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.DLblsExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension>()
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
