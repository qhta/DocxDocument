namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BubbleSerExtensionList Class.
/// </summary>
public partial class BubbleSerExtensionListImpl: ModelElementImpl, BubbleSerExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BubbleSerExtensionListImpl(): base() {}
  
  public BubbleSerExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.BubbleSerExtension>? BubbleSerExtensions
  {
    get
    {
      if (_BubbleSerExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.BubbleSerExtensionImpl(item)).ToList();
          _BubbleSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.BubbleSerExtension>(items);
        }
        else
          _BubbleSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.BubbleSerExtension>();
        _BubbleSerExtensions.CollectionChanged += _BubbleSerExtensions_CollectionChanged;
      }
      return _BubbleSerExtensions;
    }
    set
    {
      if (value != null && value != _BubbleSerExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.BubbleSerExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.BubbleSerExtension> observableCollection)
        _BubbleSerExtensions = observableCollection;
      else if (value != null)
        _BubbleSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.BubbleSerExtension>(value);
      else
       _BubbleSerExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.BubbleSerExtension>? _BubbleSerExtensions;
  
  private void _BubbleSerExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.BubbleSerExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.BubbleSerExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension>()
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
