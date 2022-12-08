namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Level Definition.
/// </summary>
public class LevelImpl: ModelElementImpl, Level
{
  public DocumentFormat.OpenXml.Wordprocessing.Level? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Level?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Numbering Level
  /// </summary>
  public Int32? LevelIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// Template Code
  /// </summary>
  public DocumentModel.HexBinaryValue? TemplateCode
  {
    get;
    set;
  }
  
  /// <summary>
  /// Tentative Numbering
  /// </summary>
  public Boolean? Tentative
  {
    get;
    set;
  }
  
  /// <summary>
  /// Starting Value.
  /// </summary>
  public Int32? StartNumberingValue
  {
    get;
    set;
  }
  
  /// <summary>
  /// Numbering Format.
  /// </summary>
  public NumberingFormat? NumberingFormat
  {
    get;
    set;
  }
  
  /// <summary>
  /// Restart Numbering Level Symbol.
  /// </summary>
  public Int32? LevelRestart
  {
    get;
    set;
  }
  
  /// <summary>
  /// Paragraph Style's Associated Numbering Level.
  /// </summary>
  public String? ParagraphStyleIdInLevel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Display All Levels Using Arabic Numerals.
  /// </summary>
  public Boolean? IsLegalNumberingStyle
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
  /// Picture Numbering Symbol Definition Reference.
  /// </summary>
  public Int32? LevelPictureBulletId
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
