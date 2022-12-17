namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document-Wide Endnote Properties.
/// </summary>
public class EndnoteDocumentWidePropertiesImpl: ModelElementImpl, EndnoteDocumentWideProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public EndnoteDocumentWidePropertiesImpl(): base() {}
  
  public EndnoteDocumentWidePropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Endnote Placement.
  /// </summary>
  public DocumentModel.Wordprocessing.EndnotePositionKind? EndnotePosition
  {
    get => (DocumentModel.Wordprocessing.EndnotePositionKind?)OpenXmlElement?.EndnotePosition?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.EndnotePosition != null)
        {
          if (value is not null)
            OpenXmlElement.EndnotePosition.Val = (DocumentFormat.OpenXml.Wordprocessing.EndnotePositionValues?)value;
          else
            OpenXmlElement.EndnotePosition = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.EndnotePosition = new DocumentFormat.OpenXml.Wordprocessing.EndnotePosition{ Val = (DocumentFormat.OpenXml.Wordprocessing.EndnotePositionValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Endnote Numbering Format.
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
  
  public Collection<DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType>? EndnoteSpecialReferences
  {
    get
    {
      if (_EndnoteSpecialReferences != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.EndnoteSpecialReference>()
            .Select(item => new DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceTypeImpl(item)).ToList();
          _EndnoteSpecialReferences = new ObservableCollection<DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType>(items);
        }
        else
          _EndnoteSpecialReferences = new ObservableCollection<DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType>();
        _EndnoteSpecialReferences.CollectionChanged += _EndnoteSpecialReferences_CollectionChanged;
      }
      return _EndnoteSpecialReferences;
    }
    set
    {
      if (value != null && value != _EndnoteSpecialReferences && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.EndnoteSpecialReference>();
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
        _EndnoteSpecialReferences = observableCollection;
      else if (value != null)
        _EndnoteSpecialReferences = new ObservableCollection<DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType>(value);
      else
       _EndnoteSpecialReferences = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType>? _EndnoteSpecialReferences;
  
  private void _EndnoteSpecialReferences_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.EndnoteSpecialReference>();
          break;
        case NotifyCollectionChangedAction.Add:
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
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceTypeImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.EndnoteSpecialReference>()
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
