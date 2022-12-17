namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentsEx Class.
/// </summary>
public class CommentsExImpl: ModelElementImpl, CommentsEx
{
  public DocumentFormat.OpenXml.Office2013.Word.CommentsEx? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Word.CommentsEx?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CommentsExImpl(): base() {}
  
  public CommentsExImpl(DocumentFormat.OpenXml.Office2013.Word.CommentsEx openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Wordprocessing.CommentEx>? CommentExs
  {
    get
    {
      if (_CommentExs != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2013.Word.CommentEx>()
            .Select(item => new DocumentModel.Wordprocessing.CommentExImpl(item)).ToList();
          _CommentExs = new ObservableCollection<DocumentModel.Wordprocessing.CommentEx>(items);
        }
        else
          _CommentExs = new ObservableCollection<DocumentModel.Wordprocessing.CommentEx>();
        _CommentExs.CollectionChanged += _CommentExs_CollectionChanged;
      }
      return _CommentExs;
    }
    set
    {
      if (value != null && value != _CommentExs && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.Word.CommentEx>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.CommentExImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.CommentEx> observableCollection)
        _CommentExs = observableCollection;
      else if (value != null)
        _CommentExs = new ObservableCollection<DocumentModel.Wordprocessing.CommentEx>(value);
      else
       _CommentExs = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.CommentEx>? _CommentExs;
  
  private void _CommentExs_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.Word.CommentEx>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.CommentExImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.CommentExImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2013.Word.CommentEx>()
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
