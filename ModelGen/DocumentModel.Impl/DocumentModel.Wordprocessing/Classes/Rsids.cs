namespace DocumentModel.Wordprocessing;

/// <summary>
/// Listing of All Revision Save ID Values.
/// </summary>
public class RsidsImpl: ModelElementImpl, Rsids
{
  public DocumentFormat.OpenXml.Wordprocessing.Rsids? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Rsids?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RsidsImpl(): base() {}
  
  public RsidsImpl(DocumentFormat.OpenXml.Wordprocessing.Rsids openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Original Document Revision Save ID.
  /// </summary>
  public HexWord? RsidRoot
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RsidRoot>();
        return (HexWord?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RsidRoot>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (string?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.RsidRoot{ Val = (string?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Collection<HexWord>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Rsid>()
            .Select(item => new HexWord(item.Val?.Value??"0000")).ToList();
          _Items = new ObservableCollection<HexWord>(items);
        }
        else
          _Items = new ObservableCollection<HexWord>();
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
      if (value is ObservableCollection<HexWord> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<HexWord>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<HexWord>? _Items;
  
  private void _Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Rsid>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            var newItem = new DocumentFormat.OpenXml.Wordprocessing.Rsid { Val = (string?)val };
            OpenXmlElement.AddChild(newItem);
          }
          break;
        case NotifyCollectionChangedAction.Remove:
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
