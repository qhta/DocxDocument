namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OfficeStyleSheetExtensionList Class.
/// </summary>
public class OfficeStyleSheetExtensionListImpl: ModelElementImpl, OfficeStyleSheetExtensionList
{
  public DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OfficeStyleSheetExtensionListImpl(): base() {}
  
  public OfficeStyleSheetExtensionListImpl(DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.OfficeStyleSheetExtension>? OfficeStyleSheetExtensions
  {
    get
    {
      if (_OfficeStyleSheetExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension>()
            .Select(item => new DocumentModel.Drawings.OfficeStyleSheetExtensionImpl(item)).ToList();
          _OfficeStyleSheetExtensions = new ObservableCollection<DocumentModel.Drawings.OfficeStyleSheetExtension>(items);
        }
        else
          _OfficeStyleSheetExtensions = new ObservableCollection<DocumentModel.Drawings.OfficeStyleSheetExtension>();
        _OfficeStyleSheetExtensions.CollectionChanged += _OfficeStyleSheetExtensions_CollectionChanged;
      }
      return _OfficeStyleSheetExtensions;
    }
    set
    {
      if (value != null && value != _OfficeStyleSheetExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.OfficeStyleSheetExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.OfficeStyleSheetExtension> observableCollection)
        _OfficeStyleSheetExtensions = observableCollection;
      else if (value != null)
        _OfficeStyleSheetExtensions = new ObservableCollection<DocumentModel.Drawings.OfficeStyleSheetExtension>(value);
      else
       _OfficeStyleSheetExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.OfficeStyleSheetExtension>? _OfficeStyleSheetExtensions;
  
  private void _OfficeStyleSheetExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.OfficeStyleSheetExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.OfficeStyleSheetExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension>()
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
