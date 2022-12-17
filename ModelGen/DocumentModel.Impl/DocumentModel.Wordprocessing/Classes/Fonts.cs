namespace DocumentModel.Wordprocessing;

/// <summary>
/// Font Table Root Element.
/// </summary>
public class FontsImpl: ModelElementImpl, Fonts
{
  public DocumentFormat.OpenXml.Wordprocessing.Fonts? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Fonts?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FontsImpl(): base() {}
  
  public FontsImpl(DocumentFormat.OpenXml.Wordprocessing.Fonts openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Wordprocessing.Font>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Font>()
            .Select(item => new DocumentModel.Wordprocessing.FontImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Wordprocessing.Font>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Wordprocessing.Font>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Font>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Wordprocessing.FontImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.Font> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Wordprocessing.Font>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.Font>? _Items;
  
  private void _Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Font>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Wordprocessing.FontImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.FontImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Font>()
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
