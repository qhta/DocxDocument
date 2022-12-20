namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ConnectorLockingExtensionList Class.
/// </summary>
public partial class ConnectorLockingExtensionListImpl: ModelElementImpl, ConnectorLockingExtensionList
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.ConnectorLockingExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ConnectorLockingExtensionList?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ConnectorLockingExtensionListImpl(): base() {}
  
  public ConnectorLockingExtensionListImpl(DocumentFormat.OpenXml.Drawing.ConnectorLockingExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.ConnectorLockingExtension>? ConnectorLockingExtensions
  {
    get
    {
      if (_ConnectorLockingExtensions == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ConnectorLockingExtension>()
            .Select(item => new DocumentModel.Drawings.ConnectorLockingExtensionImpl(item)).ToList();
          _ConnectorLockingExtensions = new ObservableCollection<DocumentModel.Drawings.ConnectorLockingExtension>(items);
        }
        else
          _ConnectorLockingExtensions = new ObservableCollection<DocumentModel.Drawings.ConnectorLockingExtension>();
        _ConnectorLockingExtensions.CollectionChanged += _ConnectorLockingExtensions_CollectionChanged;
      }
      return _ConnectorLockingExtensions;
    }
    set
    {
      if (value != null && value != _ConnectorLockingExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ConnectorLockingExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.ConnectorLockingExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ConnectorLockingExtension> observableCollection)
        _ConnectorLockingExtensions = observableCollection;
      else if (value != null)
        _ConnectorLockingExtensions = new ObservableCollection<DocumentModel.Drawings.ConnectorLockingExtension>(value);
      else
       _ConnectorLockingExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ConnectorLockingExtension>? _ConnectorLockingExtensions;
  
  private void _ConnectorLockingExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ConnectorLockingExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.ConnectorLockingExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.ConnectorLockingExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ConnectorLockingExtension>()
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
