namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentsExtensible Class.
/// </summary>
public partial class CommentsExtensibleImpl: ModelElementImpl, CommentsExtensible
{
  public DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentsExtensible? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentsExtensible?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CommentsExtensibleImpl(): base() {}
  
  public CommentsExtensibleImpl(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentsExtensible openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the WordCommentsExtensiblePart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.WordCommentsExtensiblePart? WordCommentsExtensiblePart
  {
    get
    {
      if (OpenXmlElement?.WordCommentsExtensiblePart != null)
        return new DocumentModel.Packaging.WordCommentsExtensiblePartImpl(OpenXmlElement.WordCommentsExtensiblePart);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
        if (value is DocumentModel.Packaging.WordCommentsExtensiblePartImpl valueImpl)
          if (valueImpl.OpenXmlElement != null)
              OpenXmlElement.SetPart(valueImpl.OpenXmlElement);
    }
  }
  
  public Collection<DocumentModel.Wordprocessing.CommentExtensible>? CommentExtensibles
  {
    get
    {
      if (_CommentExtensibles != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible>()
            .Select(item => new DocumentModel.Wordprocessing.CommentExtensibleImpl(item)).ToList();
          _CommentExtensibles = new ObservableCollection<DocumentModel.Wordprocessing.CommentExtensible>(items);
        }
        else
          _CommentExtensibles = new ObservableCollection<DocumentModel.Wordprocessing.CommentExtensible>();
        _CommentExtensibles.CollectionChanged += _CommentExtensibles_CollectionChanged;
      }
      return _CommentExtensibles;
    }
    set
    {
      if (value != null && value != _CommentExtensibles && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Wordprocessing.CommentExtensibleImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.CommentExtensible> observableCollection)
        _CommentExtensibles = observableCollection;
      else if (value != null)
        _CommentExtensibles = new ObservableCollection<DocumentModel.Wordprocessing.CommentExtensible>(value);
      else
       _CommentExtensibles = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.CommentExtensible>? _CommentExtensibles;
  
  private void _CommentExtensibles_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Wordprocessing.CommentExtensibleImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.CommentExtensibleImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible>()
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
  
  
  public DocumentModel.Wordprocessing.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
