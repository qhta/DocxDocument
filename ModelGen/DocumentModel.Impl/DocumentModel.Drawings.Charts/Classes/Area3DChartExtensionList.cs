namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Area3DChartExtensionList Class.
/// </summary>
public partial class Area3DChartExtensionListImpl: ModelElementImpl, Area3DChartExtensionList
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtensionList?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public Area3DChartExtensionListImpl(): base() {}
  
  public Area3DChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.Area3DChartExtension>? Area3DChartExtensions
  {
    get
    {
      if (_Area3DChartExtensions == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.Area3DChartExtensionImpl(item)).ToList();
          _Area3DChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.Area3DChartExtension>(items);
        }
        else
          _Area3DChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.Area3DChartExtension>();
        _Area3DChartExtensions.CollectionChanged += _Area3DChartExtensions_CollectionChanged;
      }
      return _Area3DChartExtensions;
    }
    set
    {
      if (value != null && value != _Area3DChartExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.Area3DChartExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.Area3DChartExtension> observableCollection)
        _Area3DChartExtensions = observableCollection;
      else if (value != null)
        _Area3DChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.Area3DChartExtension>(value);
      else
       _Area3DChartExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.Area3DChartExtension>? _Area3DChartExtensions;
  
  private void _Area3DChartExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.Area3DChartExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.Area3DChartExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtension>()
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
