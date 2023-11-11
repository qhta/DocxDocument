namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Level Definition.
/// </summary>
public partial class Level: ModelElement<DXW.Level>
{
  public Level(): base(){ }
  
  public Level(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Level(DXW.Level openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Numbering Level
  /// </summary>
  [DataMember]
  public Int32? LevelIndex
  {
    get
    {
      return _Element?.LevelIndex?.Value;
    }
    set
    {
      _ExistingElement.LevelIndex = value;
    }
  }
  
  
  /// <summary>
  ///   Template Code
  /// </summary>
  [DataMember]
  public DM.HexBinary? TemplateCode
  {
    get
    {
      if (_Element?.TemplateCode?.Value != null)
        return HexIntConverter.GetValue(_Element?.TemplateCode.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.TemplateCode = value.ToString();
      else
        _ExistingElement.TemplateCode = null;
    }
  }
  
  
  /// <summary>
  ///   Tentative Numbering
  /// </summary>
  [DataMember]
  public Boolean? Tentative
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Tentative);
    }
    set
    {
      _ExistingElement.Tentative = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Starting Value.
  /// </summary>
  [DataMember]
  public DMW.StartNumberingValue? StartNumberingValue
  {
    get
    {
      return _Element?.GetObject<DMW.StartNumberingValue,DXW.StartNumberingValue>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.StartNumberingValue,DXW.StartNumberingValue>(value);
    }
  }
  
  
  /// <summary>
  ///   Numbering Format.
  /// </summary>
  [DataMember]
  public DMW.NumberingFormat? NumberingFormat
  {
    get
    {
      return _Element?.GetObject<DMW.NumberingFormat,DXW.NumberingFormat>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NumberingFormat,DXW.NumberingFormat>(value);
    }
  }
  
  
  /// <summary>
  ///   Restart Numbering Level Symbol.
  /// </summary>
  [DataMember]
  public DMW.LevelRestart? LevelRestart
  {
    get
    {
      return _Element?.GetObject<DMW.LevelRestart,DXW.LevelRestart>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.LevelRestart,DXW.LevelRestart>(value);
    }
  }
  
  
  /// <summary>
  ///   Paragraph Style's Associated Numbering Level.
  /// </summary>
  [DataMember]
  public DMW.ParagraphStyleIdInLevel? ParagraphStyleIdInLevel
  {
    get
    {
      return _Element?.GetObject<DMW.ParagraphStyleIdInLevel,DXW.ParagraphStyleIdInLevel>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ParagraphStyleIdInLevel,DXW.ParagraphStyleIdInLevel>(value);
    }
  }
  
  
  /// <summary>
  ///   Display All Levels Using Arabic Numerals.
  /// </summary>
  [DataMember]
  public DMW.IsLegalNumberingStyle? IsLegalNumberingStyle
  {
    get
    {
      return _Element?.GetObject<DMW.IsLegalNumberingStyle,DXW.IsLegalNumberingStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.IsLegalNumberingStyle,DXW.IsLegalNumberingStyle>(value);
    }
  }
  
  
  /// <summary>
  ///   Content Between Numbering Symbol and Paragraph Text.
  /// </summary>
  [DataMember]
  public DMW.LevelSuffixKind? LevelSuffix
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues, DMW.LevelSuffixKind>(_ExistingElement.GetFirstChild<DXW.LevelSuffix>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.LevelSuffix>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues, DMW.LevelSuffixKind>(itemElement, (DMW.LevelSuffixKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.LevelSuffix, DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues, DMW.LevelSuffixKind>((DMW.LevelSuffixKind)value));
    }
  }
  
  
  /// <summary>
  ///   Numbering Level Text.
  /// </summary>
  [DataMember]
  public DMW.LevelText? LevelText
  {
    get
    {
      return _Element?.GetObject<DMW.LevelText,DXW.LevelText>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.LevelText,DXW.LevelText>(value);
    }
  }
  
  
  /// <summary>
  ///   Picture Numbering Symbol Definition Reference.
  /// </summary>
  [DataMember]
  public DMW.LevelPictureBulletId? LevelPictureBulletId
  {
    get
    {
      return _Element?.GetObject<DMW.LevelPictureBulletId,DXW.LevelPictureBulletId>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.LevelPictureBulletId,DXW.LevelPictureBulletId>(value);
    }
  }
  
  
  /// <summary>
  ///   Legacy Numbering Level Properties.
  /// </summary>
  [DataMember]
  public DMW.LegacyNumbering? LegacyNumbering
  {
    get
    {
      return _Element?.GetObject<DMW.LegacyNumbering,DXW.LegacyNumbering>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.LegacyNumbering,DXW.LegacyNumbering>(value);
    }
  }
  
  
  /// <summary>
  ///   Justification.
  /// </summary>
  [DataMember]
  public DMW.LevelJustificationKind? LevelJustification
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues, DMW.LevelJustificationKind>(_ExistingElement.GetFirstChild<DXW.LevelJustification>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.LevelJustification>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues, DMW.LevelJustificationKind>(itemElement, (DMW.LevelJustificationKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.LevelJustification, DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues, DMW.LevelJustificationKind>((DMW.LevelJustificationKind)value));
    }
  }
  
  
  /// <summary>
  ///   Numbering Level Associated Paragraph Properties.
  /// </summary>
  [DataMember]
  public DMW.PreviousParagraphProperties? PreviousParagraphProperties
  {
    get
    {
      return _Element?.GetObject<DMW.PreviousParagraphProperties,DXW.PreviousParagraphProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PreviousParagraphProperties,DXW.PreviousParagraphProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Numbering Symbol Run Properties.
  /// </summary>
  [DataMember]
  public DMW.NumberingSymbolRunProperties? NumberingSymbolRunProperties
  {
    get
    {
      return _Element?.GetObject<DMW.NumberingSymbolRunProperties,DXW.NumberingSymbolRunProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NumberingSymbolRunProperties,DXW.NumberingSymbolRunProperties>(value);
    }
  }
  
}
