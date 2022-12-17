namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the SurfaceChartExtensionList Class.
/// </summary>
public class SurfaceChartExtensionListImpl: ModelElementImpl, SurfaceChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SurfaceChartExtensionListImpl(): base() {}
  
  public SurfaceChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.SurfaceChartExtension>? SurfaceChartExtensions
  {
    get
    {
      if (_SurfaceChartExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.SurfaceChartExtensionImpl(item)).ToList();
          _SurfaceChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.SurfaceChartExtension>(items);
        }
        else
          _SurfaceChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.SurfaceChartExtension>();
        _SurfaceChartExtensions.CollectionChanged += _SurfaceChartExtensions_CollectionChanged;
      }
      return _SurfaceChartExtensions;
    }
    set
    {
      if (value != null && value != _SurfaceChartExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.SurfaceChartExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.SurfaceChartExtension> observableCollection)
        _SurfaceChartExtensions = observableCollection;
      else if (value != null)
        _SurfaceChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.SurfaceChartExtension>(value);
      else
       _SurfaceChartExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.SurfaceChartExtension>? _SurfaceChartExtensions;
  
  private void _SurfaceChartExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.SurfaceChartExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.SurfaceChartExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension>()
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
