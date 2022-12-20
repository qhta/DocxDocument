namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DateAxExtensionList Class.
/// </summary>
public partial class DateAxExtensionListImpl: ModelElementImpl, DateAxExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DateAxExtensionListImpl(): base() {}
  
  public DateAxExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.DateAxExtension>? DateAxExtensions
  {
    get
    {
      if (_DateAxExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DateAxExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.DateAxExtensionImpl(item)).ToList();
          _DateAxExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.DateAxExtension>(items);
        }
        else
          _DateAxExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.DateAxExtension>();
        _DateAxExtensions.CollectionChanged += _DateAxExtensions_CollectionChanged;
      }
      return _DateAxExtensions;
    }
    set
    {
      if (value != null && value != _DateAxExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DateAxExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.DateAxExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.DateAxExtension> observableCollection)
        _DateAxExtensions = observableCollection;
      else if (value != null)
        _DateAxExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.DateAxExtension>(value);
      else
       _DateAxExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.DateAxExtension>? _DateAxExtensions;
  
  private void _DateAxExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DateAxExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.DateAxExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.DateAxExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DateAxExtension>()
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
