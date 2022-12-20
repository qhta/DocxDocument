namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Surface3DChartExtensionList Class.
/// </summary>
public partial class Surface3DChartExtensionListImpl: ModelElementImpl, Surface3DChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Surface3DChartExtensionListImpl(): base() {}
  
  public Surface3DChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.Surface3DChartExtension>? Surface3DChartExtensions
  {
    get
    {
      if (_Surface3DChartExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.Surface3DChartExtensionImpl(item)).ToList();
          _Surface3DChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.Surface3DChartExtension>(items);
        }
        else
          _Surface3DChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.Surface3DChartExtension>();
        _Surface3DChartExtensions.CollectionChanged += _Surface3DChartExtensions_CollectionChanged;
      }
      return _Surface3DChartExtensions;
    }
    set
    {
      if (value != null && value != _Surface3DChartExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.Surface3DChartExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.Surface3DChartExtension> observableCollection)
        _Surface3DChartExtensions = observableCollection;
      else if (value != null)
        _Surface3DChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.Surface3DChartExtension>(value);
      else
       _Surface3DChartExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.Surface3DChartExtension>? _Surface3DChartExtensions;
  
  private void _Surface3DChartExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.Surface3DChartExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.Surface3DChartExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtension>()
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
