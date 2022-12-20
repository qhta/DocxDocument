namespace DocumentModel;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public partial class ExtensionListImpl: ModelElementImpl, ExtensionList
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ExtensionListImpl(): base() {}
  
  public ExtensionListImpl(DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Extension>? Extensions
  {
    get
    {
      if (_Extensions == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension>()
            .Select(item => new DocumentModel.ExtensionImpl(item)).ToList();
          _Extensions = new ObservableCollection<DocumentModel.Extension>(items);
        }
        else
          _Extensions = new ObservableCollection<DocumentModel.Extension>();
        _Extensions.CollectionChanged += _Extensions_CollectionChanged;
      }
      return _Extensions;
    }
    set
    {
      if (value != null && value != _Extensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.ExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Extension> observableCollection)
        _Extensions = observableCollection;
      else if (value != null)
        _Extensions = new ObservableCollection<DocumentModel.Extension>(value);
      else
       _Extensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Extension>? _Extensions;
  
  private void _Extensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.ExtensionImpl valImpl)
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
              if (val is DocumentModel.ExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension>()
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
