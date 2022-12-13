namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the StockChartExtensionList Class.
/// </summary>
public class StockChartExtensionListImpl: ModelElementImpl, StockChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.StockChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StockChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StockChartExtensionListImpl(): base() {}
  
  public StockChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.StockChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.StockChartExtension>? StockChartExtensions
  {
    get
    {
      if (_StockChartExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.StockChartExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.StockChartExtensionImpl(item)).ToList();
          _StockChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.StockChartExtension>(items);
        }
        else
          _StockChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.StockChartExtension>();
        _StockChartExtensions.CollectionChanged += _StockChartExtensions_CollectionChanged;
      }
      return _StockChartExtensions;
    }
    set
    {
      if (value != null && value != _StockChartExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.StockChartExtension>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.StockChartExtensionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.StockChartExtension> observableCollection)
        _StockChartExtensions = observableCollection;
      else if (value != null)
        _StockChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.StockChartExtension>(value);
      else
       _StockChartExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.StockChartExtension>? _StockChartExtensions;
  
  private void _StockChartExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.StockChartExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.StockChartExtensionImpl valImpl)
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
        if (val is DocumentModel.Drawings.Charts.StockChartExtensionImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.StockChartExtension>()
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
