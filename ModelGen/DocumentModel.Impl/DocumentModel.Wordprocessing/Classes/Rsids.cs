namespace DocumentModel.Wordprocessing;

/// <summary>
/// Listing of All Revision Save ID Values.
/// </summary>
public partial class RsidsImpl: ModelElementImpl, Rsids
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.Rsids? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Rsids?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public RsidsImpl(): base() {}
  
  public RsidsImpl(DocumentFormat.OpenXml.Wordprocessing.Rsids openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Original Document Revision Save ID.
  /// </summary>
  public DocumentModel.HexWord? RsidRoot
  {
    get => (DocumentModel.HexWord?)OpenXmlElement?.RsidRoot?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.RsidRoot != null)
        {
          if (value is not null)
            OpenXmlElement.RsidRoot.Val = (string?)value;
          else
            OpenXmlElement.RsidRoot = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.RsidRoot = new DocumentFormat.OpenXml.Wordprocessing.RsidRoot{ Val = (string?)value };
        }
      }
    }
  }
  
  public Collection<DocumentModel.HexWord>? Items
  {
    get
    {
      if (_Items == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Rsid>()
            .Select(item => new DocumentModel.HexWord(item.Val?.Value ?? "0000")).ToList();
          _Items = new ObservableCollection<DocumentModel.HexWord>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.HexWord>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Rsid>();
        foreach (var val in value)
        {
          var item = new DocumentFormat.OpenXml.Wordprocessing.Rsid{ Val = (string?)val };
          OpenXmlElement.AddChild(item);
        }
      }
      if (value is ObservableCollection<DocumentModel.HexWord> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.HexWord>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.HexWord>? _Items;
  
  private void _Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Rsid>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            var newItem = new DocumentFormat.OpenXml.Wordprocessing.Rsid { Val = (string?)val };
            OpenXmlElement.AddChild(newItem);
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Rsid>()
                          .FirstOrDefault(anItem => anItem.Val == (string?)val);
            if (oldItem != null)
              oldItem.Remove();
          }
          break;
        default:
          break;
      }
    }
  }
  
  
}
