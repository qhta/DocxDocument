namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Cell.
/// </summary>
public class TableCellImpl: ModelElementImpl, TableCell
{
  public DocumentFormat.OpenXml.Wordprocessing.TableCell? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableCell?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TableCellImpl(): base() {}
  
  public TableCellImpl(DocumentFormat.OpenXml.Wordprocessing.TableCell openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Table Cell Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellProperties? TableCellProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
  
  public DocumentModel.Wordprocessing.MoveBookmarkType? MoveFromRangeStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? MoveFromRangeEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.MoveBookmarkType? MoveToRangeStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? MoveToRangeEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlInsRangeStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlInsRangeEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlDelRangeStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlDelRangeEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlMoveFromRangeStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlMoveFromRangeEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlMoveToRangeStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlMoveToRangeEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlConflictInsertionRangeStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlConflictInsertionRangeEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlConflictDeletionRangeStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlConflictDeletionRangeEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.InsertedRun? InsertedRun
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.DeletedRun? DeletedRun
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.MoveFromRun? MoveFromRun
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.MoveToRun? MoveToRun
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.RunConflictInsertion? RunConflictInsertion
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.RunConflictDeletion? RunConflictDeletion
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
