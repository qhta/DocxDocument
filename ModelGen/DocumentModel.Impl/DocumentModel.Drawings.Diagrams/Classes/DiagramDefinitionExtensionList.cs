namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// List of extensions to the CT_DiagramDefintions type..
/// </summary>
public partial class DiagramDefinitionExtensionListImpl: ModelElementImpl, DiagramDefinitionExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DiagramDefinitionExtensionListImpl(): base() {}
  
  public DiagramDefinitionExtensionListImpl(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Diagrams.DiagramDefinitionExtension>? DiagramDefinitionExtensions
  {
    get
    {
      if (_DiagramDefinitionExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension>()
            .Select(item => new DocumentModel.Drawings.Diagrams.DiagramDefinitionExtensionImpl(item)).ToList();
          _DiagramDefinitionExtensions = new ObservableCollection<DocumentModel.Drawings.Diagrams.DiagramDefinitionExtension>(items);
        }
        else
          _DiagramDefinitionExtensions = new ObservableCollection<DocumentModel.Drawings.Diagrams.DiagramDefinitionExtension>();
        _DiagramDefinitionExtensions.CollectionChanged += _DiagramDefinitionExtensions_CollectionChanged;
      }
      return _DiagramDefinitionExtensions;
    }
    set
    {
      if (value != null && value != _DiagramDefinitionExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Diagrams.DiagramDefinitionExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Diagrams.DiagramDefinitionExtension> observableCollection)
        _DiagramDefinitionExtensions = observableCollection;
      else if (value != null)
        _DiagramDefinitionExtensions = new ObservableCollection<DocumentModel.Drawings.Diagrams.DiagramDefinitionExtension>(value);
      else
       _DiagramDefinitionExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Diagrams.DiagramDefinitionExtension>? _DiagramDefinitionExtensions;
  
  private void _DiagramDefinitionExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Diagrams.DiagramDefinitionExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Diagrams.DiagramDefinitionExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension>()
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
