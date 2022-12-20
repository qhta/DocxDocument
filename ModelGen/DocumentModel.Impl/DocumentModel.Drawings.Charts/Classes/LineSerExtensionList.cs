namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the LineSerExtensionList Class.
/// </summary>
public partial class LineSerExtensionListImpl: ModelElementImpl, LineSerExtensionList
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public LineSerExtensionListImpl(): base() {}
  
  public LineSerExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.LineSerExtension>? LineSerExtensions
  {
    get
    {
      if (_LineSerExtensions == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.LineSerExtensionImpl(item)).ToList();
          _LineSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.LineSerExtension>(items);
        }
        else
          _LineSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.LineSerExtension>();
        _LineSerExtensions.CollectionChanged += _LineSerExtensions_CollectionChanged;
      }
      return _LineSerExtensions;
    }
    set
    {
      if (value != null && value != _LineSerExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.LineSerExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.LineSerExtension> observableCollection)
        _LineSerExtensions = observableCollection;
      else if (value != null)
        _LineSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.LineSerExtension>(value);
      else
       _LineSerExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.LineSerExtension>? _LineSerExtensions;
  
  private void _LineSerExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.LineSerExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.LineSerExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension>()
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
