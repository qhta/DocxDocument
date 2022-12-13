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
  
  public LevelImpl(): base() {}
  
  public LevelImpl(DocumentFormat.OpenXml.Wordprocessing.Level openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Numbering Level
  /// </summary>
  public Int32? LevelIndex
  {
    get => (System.Int32?)OpenXmlElement?.LevelIndex?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LevelIndex = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Template Code
  /// </summary>
  public DocumentModel.HexBinaryValue? TemplateCode
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Tentative Numbering
  /// </summary>
  public Boolean? Tentative
  {
    get => (System.Boolean?)OpenXmlElement?.Tentative?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Tentative = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Starting Value.
  /// </summary>
  public Int32? StartNumberingValue
  {
    get => (System.Int32?)OpenXmlElement?.StartNumberingValue?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.StartNumberingValue != null)
        {
          if (value is not null)
            OpenXmlElement.StartNumberingValue.Val = (System.Int32?)value;
          else
            OpenXmlElement.StartNumberingValue = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.StartNumberingValue = new DocumentFormat.OpenXml.Wordprocessing.StartNumberingValue{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Numbering Format.
  /// </summary>
  public DocumentModel.Wordprocessing.NumberingFormat? NumberingFormat
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Restart Numbering Level Symbol.
  /// </summary>
  public Int32? LevelRestart
  {
    get => (System.Int32?)OpenXmlElement?.LevelRestart?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.LevelRestart != null)
        {
          if (value is not null)
            OpenXmlElement.LevelRestart.Val = (System.Int32?)value;
          else
            OpenXmlElement.LevelRestart = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.LevelRestart = new DocumentFormat.OpenXml.Wordprocessing.LevelRestart{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Paragraph Style's Associated Numbering Level.
  /// </summary>
  public String? ParagraphStyleIdInLevel
  {
    get => (System.String?)OpenXmlElement?.ParagraphStyleIdInLevel?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ParagraphStyleIdInLevel != null)
        {
          if (value is not null)
            OpenXmlElement.ParagraphStyleIdInLevel.Val = (System.String?)value;
          else
            OpenXmlElement.ParagraphStyleIdInLevel = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ParagraphStyleIdInLevel = new DocumentFormat.OpenXml.Wordprocessing.ParagraphStyleIdInLevel{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Display All Levels Using Arabic Numerals.
  /// </summary>
  public Boolean? IsLegalNumberingStyle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.IsLegalNumberingStyle>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.IsLegalNumberingStyle>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.IsLegalNumberingStyle();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Content Between Numbering Symbol and Paragraph Text.
  /// </summary>
  public DocumentModel.Wordprocessing.LevelSuffixKind? LevelSuffix
  {
    get => (DocumentModel.Wordprocessing.LevelSuffixKind?)OpenXmlElement?.LevelSuffix?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.LevelSuffix != null)
        {
          if (value is not null)
            OpenXmlElement.LevelSuffix.Val = (DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues?)value;
          else
            OpenXmlElement.LevelSuffix = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.LevelSuffix = new DocumentFormat.OpenXml.Wordprocessing.LevelSuffix{ Val = (DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Numbering Level Text.
  /// </summary>
  public DocumentModel.Wordprocessing.LevelText? LevelText
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Picture Numbering Symbol Definition Reference.
  /// </summary>
  public Int32? LevelPictureBulletId
  {
    get => (System.Int32?)OpenXmlElement?.LevelPictureBulletId?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.LevelPictureBulletId != null)
        {
          if (value is not null)
            OpenXmlElement.LevelPictureBulletId.Val = (System.Int32?)value;
          else
            OpenXmlElement.LevelPictureBulletId = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.LevelPictureBulletId = new DocumentFormat.OpenXml.Wordprocessing.LevelPictureBulletId{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Legacy Numbering Level Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.LegacyNumbering? LegacyNumbering
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Justification.
  /// </summary>
  public DocumentModel.Wordprocessing.LevelJustificationKind? LevelJustification
  {
    get => (DocumentModel.Wordprocessing.LevelJustificationKind?)OpenXmlElement?.LevelJustification?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.LevelJustification != null)
        {
          if (value is not null)
            OpenXmlElement.LevelJustification.Val = (DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues?)value;
          else
            OpenXmlElement.LevelJustification = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.LevelJustification = new DocumentFormat.OpenXml.Wordprocessing.LevelJustification{ Val = (DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Numbering Level Associated Paragraph Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.PreviousParagraphProperties? PreviousParagraphProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Numbering Symbol Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.NumberingSymbolRunProperties? NumberingSymbolRunProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
