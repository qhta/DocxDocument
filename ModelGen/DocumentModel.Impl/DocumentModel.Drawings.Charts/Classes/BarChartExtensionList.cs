namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BarChartExtensionList Class.
/// </summary>
public class BarChartExtensionListImpl: ModelElementImpl, BarChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.BarChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BarChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BarChartExtensionListImpl(): base() {}
  
  public BarChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.BarChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.BarChartExtension>? BarChartExtensions
  {
    get
    {
      if (_BarChartExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.BarChartExtensionImpl(item)).ToList();
          _BarChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.BarChartExtension>(items);
        }
        else
          _BarChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.BarChartExtension>();
        _BarChartExtensions.CollectionChanged += _BarChartExtensions_CollectionChanged;
      }
      return _BarChartExtensions;
    }
    set
    {
      if (value != null && value != _BarChartExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.BarChartExtensionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.BarChartExtension> observableCollection)
        _BarChartExtensions = observableCollection;
      else if (value != null)
        _BarChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.BarChartExtension>(value);
      else
       _BarChartExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.BarChartExtension>? _BarChartExtensions;
  
  private void _BarChartExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.BarChartExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.BarChartExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension>()
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
