namespace DocumentModel.Wordprocessing;

/// <summary>
/// Comment Content.
/// </summary>
public class CommentImpl: ModelElementImpl, Comment
{
  public DocumentFormat.OpenXml.Wordprocessing.Comment? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Comment?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CommentImpl(): base() {}
  
  public CommentImpl(DocumentFormat.OpenXml.Wordprocessing.Comment openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// initials
  /// </summary>
  public String? Initials
  {
    get => (System.String?)OpenXmlElement?.Initials?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Initials = (System.String?)value;
    }
  }
  
  /// <summary>
  /// author
  /// </summary>
  public String? Author
  {
    get => (System.String?)OpenXmlElement?.Author?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Author = (System.String?)value;
    }
  }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date
  {
    get => (System.DateTime?)OpenXmlElement?.Date?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Date = (System.DateTime?)value;
    }
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  public Collection<DocumentModel.Wordprocessing.AltChunk>? AltChunks
  {
    get
    {
      if (_AltChunks != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.AltChunk>()
            .Select(item => new DocumentModel.Wordprocessing.AltChunkImpl(item)).ToList();
          _AltChunks = new ObservableCollection<DocumentModel.Wordprocessing.AltChunk>(items);
        }
        else
          _AltChunks = new ObservableCollection<DocumentModel.Wordprocessing.AltChunk>();
        _AltChunks.CollectionChanged += _AltChunks_CollectionChanged;
      }
      return _AltChunks;
    }
    set
    {
      if (value != null && value != _AltChunks && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.AltChunk>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.AltChunkImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.AltChunk> observableCollection)
        _AltChunks = observableCollection;
      else if (value != null)
        _AltChunks = new ObservableCollection<DocumentModel.Wordprocessing.AltChunk>(value);
      else
       _AltChunks = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.AltChunk>? _AltChunks;
  
  private void _AltChunks_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.AltChunk>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.AltChunkImpl valImpl)
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
        if (val is DocumentModel.Wordprocessing.AltChunkImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.AltChunk>()
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
  
  
  public DocumentModel.Wordprocessing.CustomXmlBlock? CustomXmlBlock
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.SdtBlock? SdtBlock
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<DocumentModel.Wordprocessing.Paragraph>? Paragraphs
  {
    get
    {
      if (_Paragraphs != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Paragraph>()
            .Select(item => new DocumentModel.Wordprocessing.ParagraphImpl(item)).ToList();
          _Paragraphs = new ObservableCollection<DocumentModel.Wordprocessing.Paragraph>(items);
        }
        else
          _Paragraphs = new ObservableCollection<DocumentModel.Wordprocessing.Paragraph>();
        _Paragraphs.CollectionChanged += _Paragraphs_CollectionChanged;
      }
      return _Paragraphs;
    }
    set
    {
      if (value != null && value != _Paragraphs && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.ParagraphImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.Paragraph> observableCollection)
        _Paragraphs = observableCollection;
      else if (value != null)
        _Paragraphs = new ObservableCollection<DocumentModel.Wordprocessing.Paragraph>(value);
      else
       _Paragraphs = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.Paragraph>? _Paragraphs;
  
  private void _Paragraphs_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.ParagraphImpl valImpl)
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
        if (val is DocumentModel.Wordprocessing.ParagraphImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Paragraph>()
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
  
  
  public Collection<DocumentModel.Wordprocessing.Table>? Tables
  {
    get
    {
      if (_Tables != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Table>()
            .Select(item => new DocumentModel.Wordprocessing.TableImpl(item)).ToList();
          _Tables = new ObservableCollection<DocumentModel.Wordprocessing.Table>(items);
        }
        else
          _Tables = new ObservableCollection<DocumentModel.Wordprocessing.Table>();
        _Tables.CollectionChanged += _Tables_CollectionChanged;
      }
      return _Tables;
    }
    set
    {
      if (value != null && value != _Tables && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Table>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.TableImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.Table> observableCollection)
        _Tables = observableCollection;
      else if (value != null)
        _Tables = new ObservableCollection<DocumentModel.Wordprocessing.Table>(value);
      else
       _Tables = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.Table>? _Tables;
  
  private void _Tables_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Table>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.TableImpl valImpl)
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
        if (val is DocumentModel.Wordprocessing.TableImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Table>()
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
  
  
  public DocumentModel.Wordprocessing.ProofError? ProofError
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.PermStart? PermStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.PermEnd? PermEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.BookmarkStart? BookmarkStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? BookmarkEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? CommentRangeStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? CommentRangeEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
