namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Mcds Class.
/// </summary>
public class McdsImpl: ModelElementImpl, Mcds
{
  public DocumentFormat.OpenXml.Office.Word.Mcds? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.Mcds?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public McdsImpl(): base() {}
  
  public McdsImpl(DocumentFormat.OpenXml.Office.Word.Mcds openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Wordprocessing.Mcd>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.Mcd>()
            .Select(item => new DocumentModel.Wordprocessing.McdImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Wordprocessing.Mcd>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Wordprocessing.Mcd>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.Mcd>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.McdImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.Mcd> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Wordprocessing.Mcd>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.Mcd>? _Items;
  
  private void _Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.Mcd>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.McdImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.McdImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.Mcd>()
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
