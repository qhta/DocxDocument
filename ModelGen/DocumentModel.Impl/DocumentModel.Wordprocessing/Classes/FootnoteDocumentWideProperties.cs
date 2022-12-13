namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document-Wide Footnote Properties.
/// </summary>
public class FootnoteDocumentWidePropertiesImpl: ModelElementImpl, FootnoteDocumentWideProperties
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
  
  public DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType? FootnoteSpecialReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
