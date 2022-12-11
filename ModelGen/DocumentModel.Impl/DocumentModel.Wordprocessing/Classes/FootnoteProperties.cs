namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FootnoteProperties Class.
/// </summary>
public class FootnotePropertiesImpl: ModelElementImpl, FootnoteProperties
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
  public FootnotePositionKind? FootnotePosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnotePosition>();
        return (FootnotePositionKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnotePosition>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Wordprocessing.FootnotePositionValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.FootnotePosition{ Val = (DocumentFormat.OpenXml.Wordprocessing.FootnotePositionValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Footnote Numbering Format.
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
  
}
