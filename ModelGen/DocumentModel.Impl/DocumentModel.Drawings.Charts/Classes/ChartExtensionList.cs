namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Extensibility container.
/// </summary>
public class ChartExtensionListImpl: ModelElementImpl, ChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.ChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ChartExtensionListImpl(): base() {}
  
  public ChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.ChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.DataDisplayOptions16>? DataDisplayOptions16s
  {
    get
    {
      if (_DataDisplayOptions16s != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16>()
            .Select(item => new DocumentModel.Drawings.Charts.DataDisplayOptions16Impl(item)).ToList();
          _DataDisplayOptions16s = new ObservableCollection<DocumentModel.Drawings.Charts.DataDisplayOptions16>(items);
        }
        else
          _DataDisplayOptions16s = new ObservableCollection<DocumentModel.Drawings.Charts.DataDisplayOptions16>();
        _DataDisplayOptions16s.CollectionChanged += _DataDisplayOptions16s_CollectionChanged;
      }
      return _DataDisplayOptions16s;
    }
    set
    {
      if (value != null && value != _DataDisplayOptions16s && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.DataDisplayOptions16Impl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.DataDisplayOptions16> observableCollection)
        _DataDisplayOptions16s = observableCollection;
      else if (value != null)
        _DataDisplayOptions16s = new ObservableCollection<DocumentModel.Drawings.Charts.DataDisplayOptions16>(value);
      else
       _DataDisplayOptions16s = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.DataDisplayOptions16>? _DataDisplayOptions16s;
  
  private void _DataDisplayOptions16s_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.DataDisplayOptions16Impl valImpl)
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
        if (val is DocumentModel.Drawings.Charts.DataDisplayOptions16Impl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16>()
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
