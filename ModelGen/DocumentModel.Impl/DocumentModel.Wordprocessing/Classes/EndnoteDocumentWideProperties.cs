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
  public EndnotePositionKind? EndnotePosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnotePosition>();
        return (EndnotePositionKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnotePosition>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Wordprocessing.EndnotePositionValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.EndnotePosition{ Val = (DocumentFormat.OpenXml.Wordprocessing.EndnotePositionValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Endnote Numbering Format.
  /// </summary>
  public NumberingFormat? NumberingFormat
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Footnote and Endnote Numbering Starting Value.
  /// </summary>
  public UInt16? NumberingStart
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingStart>();
        return (UInt16?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingStart>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.UInt16?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.NumberingStart{ Val = (System.UInt16?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Footnote and Endnote Numbering Restart Location.
  /// </summary>
  public RestartNumberKind? NumberingRestart
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingRestart>();
        return (RestartNumberKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingRestart>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.NumberingRestart{ Val = (DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public FootnoteEndnoteSeparatorReferenceType? EndnoteSpecialReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
