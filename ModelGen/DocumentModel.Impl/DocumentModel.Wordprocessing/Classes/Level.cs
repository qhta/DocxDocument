namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Level Definition.
/// </summary>
public class LevelImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.Level>, Level
{
  /// <summary>
  /// Numbering Format.
  /// </summary>
  public NumberingFormat? NumberingFormat
  {
    get;
    set;
  }
  
  /// <summary>
  /// Content Between Numbering Symbol and Paragraph Text.
  /// </summary>
  public LevelSuffixKind? LevelSuffix
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LevelSuffix>();
        return (LevelSuffixKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LevelSuffix>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.LevelSuffix{ Val = (DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Numbering Level Text.
  /// </summary>
  public LevelText? LevelText
  {
    get;
    set;
  }
  
  /// <summary>
  /// Legacy Numbering Level Properties.
  /// </summary>
  public LegacyNumbering? LegacyNumbering
  {
    get;
    set;
  }
  
  /// <summary>
  /// Justification.
  /// </summary>
  public LevelJustificationKind? LevelJustification
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LevelJustification>();
        return (LevelJustificationKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LevelJustification>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.LevelJustification{ Val = (DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Numbering Level Associated Paragraph Properties.
  /// </summary>
  public PreviousParagraphProperties? PreviousParagraphProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Numbering Symbol Run Properties.
  /// </summary>
  public NumberingSymbolRunProperties? NumberingSymbolRunProperties
  {
    get;
    set;
  }
  
}
