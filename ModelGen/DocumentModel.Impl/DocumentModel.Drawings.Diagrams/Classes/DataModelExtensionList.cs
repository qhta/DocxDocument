namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the DataModelExtensionList Class.
/// </summary>
public class DataModelExtensionListImpl: ModelElementImpl, DataModelExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DataModelExtensionListImpl(): base() {}
  
  public DataModelExtensionListImpl(DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.DataModelExtension>? DataModelExtensions
  {
    get
    {
      if (_DataModelExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.DataModelExtension>()
            .Select(item => new DocumentModel.Drawings.DataModelExtensionImpl(item)).ToList();
          _DataModelExtensions = new ObservableCollection<DocumentModel.Drawings.DataModelExtension>(items);
        }
        else
          _DataModelExtensions = new ObservableCollection<DocumentModel.Drawings.DataModelExtension>();
        _DataModelExtensions.CollectionChanged += _DataModelExtensions_CollectionChanged;
      }
      return _DataModelExtensions;
    }
    set
    {
      if (value != null && value != _DataModelExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.DataModelExtension>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.DataModelExtensionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.DataModelExtension> observableCollection)
        _DataModelExtensions = observableCollection;
      else if (value != null)
        _DataModelExtensions = new ObservableCollection<DocumentModel.Drawings.DataModelExtension>(value);
      else
       _DataModelExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.DataModelExtension>? _DataModelExtensions;
  
  private void _DataModelExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.DataModelExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.DataModelExtensionImpl valImpl)
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
        if (val is DocumentModel.Drawings.DataModelExtensionImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.DataModelExtension>()
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
