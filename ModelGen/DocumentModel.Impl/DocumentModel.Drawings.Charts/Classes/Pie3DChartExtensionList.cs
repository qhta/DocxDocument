namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Pie3DChartExtensionList Class.
/// </summary>
public class Pie3DChartExtensionListImpl: ModelElementImpl, Pie3DChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Pie3DChartExtensionListImpl(): base() {}
  
  public Pie3DChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.Pie3DChartExtension>? Pie3DChartExtensions
  {
    get
    {
      if (_Pie3DChartExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.Pie3DChartExtensionImpl(item)).ToList();
          _Pie3DChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.Pie3DChartExtension>(items);
        }
        else
          _Pie3DChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.Pie3DChartExtension>();
        _Pie3DChartExtensions.CollectionChanged += _Pie3DChartExtensions_CollectionChanged;
      }
      return _Pie3DChartExtensions;
    }
    set
    {
      if (value != null && value != _Pie3DChartExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.Pie3DChartExtensionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.Pie3DChartExtension> observableCollection)
        _Pie3DChartExtensions = observableCollection;
      else if (value != null)
        _Pie3DChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.Pie3DChartExtension>(value);
      else
       _Pie3DChartExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.Pie3DChartExtension>? _Pie3DChartExtensions;
  
  private void _Pie3DChartExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.Pie3DChartExtensionImpl valImpl)
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
        if (val is DocumentModel.Drawings.Charts.Pie3DChartExtensionImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension>()
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
