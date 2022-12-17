namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Line3DChartExtensionList Class.
/// </summary>
public class Line3DChartExtensionListImpl: ModelElementImpl, Line3DChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Line3DChartExtensionListImpl(): base() {}
  
  public Line3DChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.Line3DChartExtension>? Line3DChartExtensions
  {
    get
    {
      if (_Line3DChartExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.Line3DChartExtensionImpl(item)).ToList();
          _Line3DChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.Line3DChartExtension>(items);
        }
        else
          _Line3DChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.Line3DChartExtension>();
        _Line3DChartExtensions.CollectionChanged += _Line3DChartExtensions_CollectionChanged;
      }
      return _Line3DChartExtensions;
    }
    set
    {
      if (value != null && value != _Line3DChartExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.Line3DChartExtensionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.Line3DChartExtension> observableCollection)
        _Line3DChartExtensions = observableCollection;
      else if (value != null)
        _Line3DChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.Line3DChartExtension>(value);
      else
       _Line3DChartExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.Line3DChartExtension>? _Line3DChartExtensions;
  
  private void _Line3DChartExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.Line3DChartExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.Line3DChartExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension>()
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
