namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the SurfaceSerExtensionList Class.
/// </summary>
public partial class SurfaceSerExtensionListImpl: ModelElementImpl, SurfaceSerExtensionList
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public SurfaceSerExtensionListImpl(): base() {}
  
  public SurfaceSerExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.SurfaceSerExtension>? SurfaceSerExtensions
  {
    get
    {
      if (_SurfaceSerExtensions == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.SurfaceSerExtensionImpl(item)).ToList();
          _SurfaceSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.SurfaceSerExtension>(items);
        }
        else
          _SurfaceSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.SurfaceSerExtension>();
        _SurfaceSerExtensions.CollectionChanged += _SurfaceSerExtensions_CollectionChanged;
      }
      return _SurfaceSerExtensions;
    }
    set
    {
      if (value != null && value != _SurfaceSerExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.SurfaceSerExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.SurfaceSerExtension> observableCollection)
        _SurfaceSerExtensions = observableCollection;
      else if (value != null)
        _SurfaceSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.SurfaceSerExtension>(value);
      else
       _SurfaceSerExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.SurfaceSerExtension>? _SurfaceSerExtensions;
  
  private void _SurfaceSerExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.SurfaceSerExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.SurfaceSerExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtension>()
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
