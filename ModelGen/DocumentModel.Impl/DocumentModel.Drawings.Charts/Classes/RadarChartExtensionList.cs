namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the RadarChartExtensionList Class.
/// </summary>
public class RadarChartExtensionListImpl: ModelElementImpl, RadarChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RadarChartExtensionListImpl(): base() {}
  
  public RadarChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.RadarChartExtension>? RadarChartExtensions
  {
    get
    {
      if (_RadarChartExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.RadarChartExtensionImpl(item)).ToList();
          _RadarChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.RadarChartExtension>(items);
        }
        else
          _RadarChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.RadarChartExtension>();
        _RadarChartExtensions.CollectionChanged += _RadarChartExtensions_CollectionChanged;
      }
      return _RadarChartExtensions;
    }
    set
    {
      if (value != null && value != _RadarChartExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.RadarChartExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.RadarChartExtension> observableCollection)
        _RadarChartExtensions = observableCollection;
      else if (value != null)
        _RadarChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.RadarChartExtension>(value);
      else
       _RadarChartExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.RadarChartExtension>? _RadarChartExtensions;
  
  private void _RadarChartExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.RadarChartExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.RadarChartExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtension>()
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
