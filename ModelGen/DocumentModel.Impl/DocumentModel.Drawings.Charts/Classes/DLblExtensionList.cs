namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DLblExtensionList Class.
/// </summary>
public class DLblExtensionListImpl: ModelElementImpl, DLblExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DLblExtensionListImpl(): base() {}
  
  public DLblExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.DLblExtension>? DLblExtensions
  {
    get
    {
      if (_DLblExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DLblExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.DLblExtensionImpl(item)).ToList();
          _DLblExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.DLblExtension>(items);
        }
        else
          _DLblExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.DLblExtension>();
        _DLblExtensions.CollectionChanged += _DLblExtensions_CollectionChanged;
      }
      return _DLblExtensions;
    }
    set
    {
      if (value != null && value != _DLblExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DLblExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.DLblExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.DLblExtension> observableCollection)
        _DLblExtensions = observableCollection;
      else if (value != null)
        _DLblExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.DLblExtension>(value);
      else
       _DLblExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.DLblExtension>? _DLblExtensions;
  
  private void _DLblExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DLblExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.DLblExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.DLblExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DLblExtension>()
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
