namespace DocumentModel.Wordprocessing;

/// <summary>
/// Comments Collection.
/// </summary>
public class CommentsImpl: ModelElementImpl, Comments
{
  public DocumentFormat.OpenXml.Wordprocessing.Comments? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Comments?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CommentsImpl(): base() {}
  
  public CommentsImpl(DocumentFormat.OpenXml.Wordprocessing.Comments openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Wordprocessing.Comment>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Comment>()
            .Select(item => new DocumentModel.Wordprocessing.CommentImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Wordprocessing.Comment>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Wordprocessing.Comment>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Comment>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.CommentImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.Comment> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Wordprocessing.Comment>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.Comment>? _Items;
  
  private void _Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Comment>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.CommentImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.CommentImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Comment>()
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
