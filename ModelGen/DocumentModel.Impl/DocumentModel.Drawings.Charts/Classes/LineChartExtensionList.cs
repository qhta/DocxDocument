namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the LineChartExtensionList Class.
/// </summary>
public class LineChartExtensionListImpl: ModelElementImpl, LineChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.LineChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.LineChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LineChartExtensionListImpl(): base() {}
  
  public LineChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.LineChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.LineChartExtension>? LineChartExtensions
  {
    get
    {
      if (_LineChartExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.LineChartExtensionImpl(item)).ToList();
          _LineChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.LineChartExtension>(items);
        }
        else
          _LineChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.LineChartExtension>();
        _LineChartExtensions.CollectionChanged += _LineChartExtensions_CollectionChanged;
      }
      return _LineChartExtensions;
    }
    set
    {
      if (value != null && value != _LineChartExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.LineChartExtensionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.LineChartExtension> observableCollection)
        _LineChartExtensions = observableCollection;
      else if (value != null)
        _LineChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.LineChartExtension>(value);
      else
       _LineChartExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.LineChartExtension>? _LineChartExtensions;
  
  private void _LineChartExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.LineChartExtensionImpl valImpl)
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
        if (val is DocumentModel.Drawings.Charts.LineChartExtensionImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension>()
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
