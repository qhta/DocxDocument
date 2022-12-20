namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the AreaChartExtensionList Class.
/// </summary>
public partial class AreaChartExtensionListImpl: ModelElementImpl, AreaChartExtensionList
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtensionList?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public AreaChartExtensionListImpl(): base() {}
  
  public AreaChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.AreaChartExtension>? AreaChartExtensions
  {
    get
    {
      if (_AreaChartExtensions == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.AreaChartExtensionImpl(item)).ToList();
          _AreaChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.AreaChartExtension>(items);
        }
        else
          _AreaChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.AreaChartExtension>();
        _AreaChartExtensions.CollectionChanged += _AreaChartExtensions_CollectionChanged;
      }
      return _AreaChartExtensions;
    }
    set
    {
      if (value != null && value != _AreaChartExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.AreaChartExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.AreaChartExtension> observableCollection)
        _AreaChartExtensions = observableCollection;
      else if (value != null)
        _AreaChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.AreaChartExtension>(value);
      else
       _AreaChartExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.AreaChartExtension>? _AreaChartExtensions;
  
  private void _AreaChartExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.AreaChartExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.AreaChartExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension>()
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
