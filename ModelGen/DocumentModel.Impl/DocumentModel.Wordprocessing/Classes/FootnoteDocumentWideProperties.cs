namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document-Wide Footnote Properties.
/// </summary>
public partial class FootnoteDocumentWidePropertiesImpl: ModelElementImpl, FootnoteDocumentWideProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FootnoteDocumentWidePropertiesImpl(): base() {}
  
  public FootnoteDocumentWidePropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Footnote Placement.
  /// </summary>
  public DocumentModel.Wordprocessing.FootnotePositionKind? FootnotePosition
  {
    get => (DocumentModel.Wordprocessing.FootnotePositionKind?)OpenXmlElement?.FootnotePosition?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.FootnotePosition != null)
        {
          if (value is not null)
            OpenXmlElement.FootnotePosition.Val = (DocumentFormat.OpenXml.Wordprocessing.FootnotePositionValues?)value;
          else
            OpenXmlElement.FootnotePosition = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.FootnotePosition = new DocumentFormat.OpenXml.Wordprocessing.FootnotePosition{ Val = (DocumentFormat.OpenXml.Wordprocessing.FootnotePositionValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Footnote Numbering Format.
  /// </summary>
  public DocumentModel.Wordprocessing.NumberingFormat? NumberingFormat
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>();
        if (item != null)
          return new DocumentModel.Wordprocessing.NumberingFormatImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.NumberingFormatImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Footnote and Endnote Numbering Starting Value.
  /// </summary>
  public UInt16? NumberingStart
  {
    get => (System.UInt16?)OpenXmlElement?.NumberingStart?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.NumberingStart != null)
        {
          if (value is not null)
            OpenXmlElement.NumberingStart.Val = (System.UInt16?)value;
          else
            OpenXmlElement.NumberingStart = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.NumberingStart = new DocumentFormat.OpenXml.Wordprocessing.NumberingStart{ Val = (System.UInt16?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Footnote and Endnote Numbering Restart Location.
  /// </summary>
  public DocumentModel.Wordprocessing.RestartNumberKind? NumberingRestart
  {
    get => (DocumentModel.Wordprocessing.RestartNumberKind?)OpenXmlElement?.NumberingRestart?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.NumberingRestart != null)
        {
          if (value is not null)
            OpenXmlElement.NumberingRestart.Val = (DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues?)value;
          else
            OpenXmlElement.NumberingRestart = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.NumberingRestart = new DocumentFormat.OpenXml.Wordprocessing.NumberingRestart{ Val = (DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues?)value };
        }
      }
    }
  }
  
  public Collection<DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType>? FootnoteSpecialReferences
  {
    get
    {
      if (_FootnoteSpecialReferences != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.FootnoteSpecialReference>()
            .Select(item => new DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceTypeImpl(item)).ToList();
          _FootnoteSpecialReferences = new ObservableCollection<DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType>(items);
        }
        else
          _FootnoteSpecialReferences = new ObservableCollection<DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType>();
        _FootnoteSpecialReferences.CollectionChanged += _FootnoteSpecialReferences_CollectionChanged;
      }
      return _FootnoteSpecialReferences;
    }
    set
    {
      if (value != null && value != _FootnoteSpecialReferences && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.FootnoteSpecialReference>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceTypeImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType> observableCollection)
        _FootnoteSpecialReferences = observableCollection;
      else if (value != null)
        _FootnoteSpecialReferences = new ObservableCollection<DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType>(value);
      else
       _FootnoteSpecialReferences = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType>? _FootnoteSpecialReferences;
  
  private void _FootnoteSpecialReferences_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.FootnoteSpecialReference>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceTypeImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceTypeImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.FootnoteSpecialReference>()
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
