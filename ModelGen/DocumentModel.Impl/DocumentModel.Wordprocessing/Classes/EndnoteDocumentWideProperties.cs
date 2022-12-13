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
  
  public DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType? EndnoteSpecialReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
