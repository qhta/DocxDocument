namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FootnoteProperties Class.
/// </summary>
public partial class FootnotePropertiesImpl: ModelElementImpl, FootnoteProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FootnotePropertiesImpl(): base() {}
  
  public FootnotePropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties openXmlElement): base(openXmlElement)
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
  
}
