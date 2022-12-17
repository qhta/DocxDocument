namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the PtExtensionList Class.
/// </summary>
public class PtExtensionListImpl: ModelElementImpl, PtExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PtExtensionListImpl(): base() {}
  
  public PtExtensionListImpl(DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.PtExtension>? PtExtensions
  {
    get
    {
      if (_PtExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.PtExtension>()
            .Select(item => new DocumentModel.Drawings.PtExtensionImpl(item)).ToList();
          _PtExtensions = new ObservableCollection<DocumentModel.Drawings.PtExtension>(items);
        }
        else
          _PtExtensions = new ObservableCollection<DocumentModel.Drawings.PtExtension>();
        _PtExtensions.CollectionChanged += _PtExtensions_CollectionChanged;
      }
      return _PtExtensions;
    }
    set
    {
      if (value != null && value != _PtExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.PtExtension>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.PtExtensionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.PtExtension> observableCollection)
        _PtExtensions = observableCollection;
      else if (value != null)
        _PtExtensions = new ObservableCollection<DocumentModel.Drawings.PtExtension>(value);
      else
       _PtExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.PtExtension>? _PtExtensions;
  
  private void _PtExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.PtExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.PtExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.PtExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.PtExtension>()
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
