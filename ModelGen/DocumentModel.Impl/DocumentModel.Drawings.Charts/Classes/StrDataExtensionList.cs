namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the StrDataExtensionList Class.
/// </summary>
public class StrDataExtensionListImpl: ModelElementImpl, StrDataExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StrDataExtensionListImpl(): base() {}
  
  public StrDataExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.StrDataExtension>? StrDataExtensions
  {
    get
    {
      if (_StrDataExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.StrDataExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.StrDataExtensionImpl(item)).ToList();
          _StrDataExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.StrDataExtension>(items);
        }
        else
          _StrDataExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.StrDataExtension>();
        _StrDataExtensions.CollectionChanged += _StrDataExtensions_CollectionChanged;
      }
      return _StrDataExtensions;
    }
    set
    {
      if (value != null && value != _StrDataExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.StrDataExtension>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.StrDataExtensionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.StrDataExtension> observableCollection)
        _StrDataExtensions = observableCollection;
      else if (value != null)
        _StrDataExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.StrDataExtension>(value);
      else
       _StrDataExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.StrDataExtension>? _StrDataExtensions;
  
  private void _StrDataExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.StrDataExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.StrDataExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.StrDataExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.StrDataExtension>()
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
