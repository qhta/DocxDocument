namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the CatAxExtensionList Class.
/// </summary>
public partial class CatAxExtensionListImpl: ModelElementImpl, CatAxExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.CatAxExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.CatAxExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CatAxExtensionListImpl(): base() {}
  
  public CatAxExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.CatAxExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.CatAxExtension>? CatAxExtensions
  {
    get
    {
      if (_CatAxExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.CatAxExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.CatAxExtensionImpl(item)).ToList();
          _CatAxExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.CatAxExtension>(items);
        }
        else
          _CatAxExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.CatAxExtension>();
        _CatAxExtensions.CollectionChanged += _CatAxExtensions_CollectionChanged;
      }
      return _CatAxExtensions;
    }
    set
    {
      if (value != null && value != _CatAxExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.CatAxExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.CatAxExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.CatAxExtension> observableCollection)
        _CatAxExtensions = observableCollection;
      else if (value != null)
        _CatAxExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.CatAxExtension>(value);
      else
       _CatAxExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.CatAxExtension>? _CatAxExtensions;
  
  private void _CatAxExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.CatAxExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.CatAxExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.CatAxExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.CatAxExtension>()
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
