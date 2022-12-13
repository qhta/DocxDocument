namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BarSerExtensionList Class.
/// </summary>
public class BarSerExtensionListImpl: ModelElementImpl, BarSerExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BarSerExtensionListImpl(): base() {}
  
  public BarSerExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.BarSerExtension>? BarSerExtensions
  {
    get
    {
      if (_BarSerExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BarSerExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.BarSerExtensionImpl(item)).ToList();
          _BarSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.BarSerExtension>(items);
        }
        else
          _BarSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.BarSerExtension>();
        _BarSerExtensions.CollectionChanged += _BarSerExtensions_CollectionChanged;
      }
      return _BarSerExtensions;
    }
    set
    {
      if (value != null && value != _BarSerExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BarSerExtension>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.BarSerExtensionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.BarSerExtension> observableCollection)
        _BarSerExtensions = observableCollection;
      else if (value != null)
        _BarSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.BarSerExtension>(value);
      else
       _BarSerExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.BarSerExtension>? _BarSerExtensions;
  
  private void _BarSerExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BarSerExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.BarSerExtensionImpl valImpl)
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
        if (val is DocumentModel.Drawings.Charts.BarSerExtensionImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BarSerExtension>()
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
