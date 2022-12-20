namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentsIds Class.
/// </summary>
public partial class CommentsIdsImpl: ModelElementImpl, CommentsIds
{
  public DocumentFormat.OpenXml.Office2019.Word.Cid.CommentsIds? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2019.Word.Cid.CommentsIds?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CommentsIdsImpl(): base() {}
  
  public CommentsIdsImpl(DocumentFormat.OpenXml.Office2019.Word.Cid.CommentsIds openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the WordprocessingCommentsIdsPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.WordprocessingCommentsIdsPart? WordprocessingCommentsIdsPart
  {
    get
    {
      if (OpenXmlElement?.WordprocessingCommentsIdsPart != null)
        return new DocumentModel.Packaging.WordprocessingCommentsIdsPartImpl(OpenXmlElement.WordprocessingCommentsIdsPart);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
        if (value is DocumentModel.Packaging.WordprocessingCommentsIdsPartImpl valueImpl)
          if (valueImpl.OpenXmlElement != null)
              OpenXmlElement.SetPart(valueImpl.OpenXmlElement);
    }
  }
  
  public Collection<DocumentModel.Wordprocessing.CommentId>? CommentIds
  {
    get
    {
      if (_CommentIds != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId>()
            .Select(item => new DocumentModel.Wordprocessing.CommentIdImpl(item)).ToList();
          _CommentIds = new ObservableCollection<DocumentModel.Wordprocessing.CommentId>(items);
        }
        else
          _CommentIds = new ObservableCollection<DocumentModel.Wordprocessing.CommentId>();
        _CommentIds.CollectionChanged += _CommentIds_CollectionChanged;
      }
      return _CommentIds;
    }
    set
    {
      if (value != null && value != _CommentIds && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Wordprocessing.CommentIdImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.CommentId> observableCollection)
        _CommentIds = observableCollection;
      else if (value != null)
        _CommentIds = new ObservableCollection<DocumentModel.Wordprocessing.CommentId>(value);
      else
       _CommentIds = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.CommentId>? _CommentIds;
  
  private void _CommentIds_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Wordprocessing.CommentIdImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.CommentIdImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId>()
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
