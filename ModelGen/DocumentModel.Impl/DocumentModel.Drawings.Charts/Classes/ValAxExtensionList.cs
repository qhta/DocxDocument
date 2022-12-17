namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ValAxExtensionList Class.
/// </summary>
public class ValAxExtensionListImpl: ModelElementImpl, ValAxExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.ValAxExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ValAxExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ValAxExtensionListImpl(): base() {}
  
  public ValAxExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.ValAxExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.ValAxExtension>? ValAxExtensions
  {
    get
    {
      if (_ValAxExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.ValAxExtensionImpl(item)).ToList();
          _ValAxExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.ValAxExtension>(items);
        }
        else
          _ValAxExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.ValAxExtension>();
        _ValAxExtensions.CollectionChanged += _ValAxExtensions_CollectionChanged;
      }
      return _ValAxExtensions;
    }
    set
    {
      if (value != null && value != _ValAxExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.ValAxExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.ValAxExtension> observableCollection)
        _ValAxExtensions = observableCollection;
      else if (value != null)
        _ValAxExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.ValAxExtension>(value);
      else
       _ValAxExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.ValAxExtension>? _ValAxExtensions;
  
  private void _ValAxExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.ValAxExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.ValAxExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension>()
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
