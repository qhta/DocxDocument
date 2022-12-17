namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ScatterChartExtensionList Class.
/// </summary>
public class ScatterChartExtensionListImpl: ModelElementImpl, ScatterChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ScatterChartExtensionListImpl(): base() {}
  
  public ScatterChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.ScatterChartExtension>? ScatterChartExtensions
  {
    get
    {
      if (_ScatterChartExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.ScatterChartExtensionImpl(item)).ToList();
          _ScatterChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.ScatterChartExtension>(items);
        }
        else
          _ScatterChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.ScatterChartExtension>();
        _ScatterChartExtensions.CollectionChanged += _ScatterChartExtensions_CollectionChanged;
      }
      return _ScatterChartExtensions;
    }
    set
    {
      if (value != null && value != _ScatterChartExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtension>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.ScatterChartExtensionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.ScatterChartExtension> observableCollection)
        _ScatterChartExtensions = observableCollection;
      else if (value != null)
        _ScatterChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.ScatterChartExtension>(value);
      else
       _ScatterChartExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.ScatterChartExtension>? _ScatterChartExtensions;
  
  private void _ScatterChartExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.ScatterChartExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.ScatterChartExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtension>()
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
