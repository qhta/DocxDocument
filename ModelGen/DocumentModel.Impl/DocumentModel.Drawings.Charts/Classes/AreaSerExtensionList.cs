namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the AreaSerExtensionList Class.
/// </summary>
public partial class AreaSerExtensionListImpl: ModelElementImpl, AreaSerExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AreaSerExtensionListImpl(): base() {}
  
  public AreaSerExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.AreaSerExtension>? AreaSerExtensions
  {
    get
    {
      if (_AreaSerExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.AreaSerExtensionImpl(item)).ToList();
          _AreaSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.AreaSerExtension>(items);
        }
        else
          _AreaSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.AreaSerExtension>();
        _AreaSerExtensions.CollectionChanged += _AreaSerExtensions_CollectionChanged;
      }
      return _AreaSerExtensions;
    }
    set
    {
      if (value != null && value != _AreaSerExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.AreaSerExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.AreaSerExtension> observableCollection)
        _AreaSerExtensions = observableCollection;
      else if (value != null)
        _AreaSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.AreaSerExtension>(value);
      else
       _AreaSerExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.AreaSerExtension>? _AreaSerExtensions;
  
  private void _AreaSerExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.AreaSerExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.AreaSerExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtension>()
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
