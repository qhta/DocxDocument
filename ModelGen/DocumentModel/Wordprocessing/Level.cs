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
        return HexIntConverter.GetValue(_ExistingElement.TemplateCode.Value);
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
      var element = _Element?.GetFirstChild<DXW.StartNumberingValue>();
      if (element != null)
        return StartNumberingValueConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.StartNumberingValue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StartNumberingValueConverter.CreateOpenXmlElement<DXW.StartNumberingValue>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.NumberingFormat>();
      if (element != null)
        return NumberingFormatConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NumberingFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingFormatConverter.CreateOpenXmlElement<DXW.NumberingFormat>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.LevelRestart>();
      if (element != null)
        return LevelRestartConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.LevelRestart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LevelRestartConverter.CreateOpenXmlElement<DXW.LevelRestart>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.ParagraphStyleIdInLevel>();
      if (element != null)
        return ParagraphStyleIdInLevelConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ParagraphStyleIdInLevel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParagraphStyleIdInLevelConverter.CreateOpenXmlElement<DXW.ParagraphStyleIdInLevel>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.IsLegalNumberingStyle>();
      if (element != null)
        return IsLegalNumberingStyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.IsLegalNumberingStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = IsLegalNumberingStyleConverter.CreateOpenXmlElement<DXW.IsLegalNumberingStyle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.LevelText>();
      if (element != null)
        return LevelTextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.LevelText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LevelTextConverter.CreateOpenXmlElement<DXW.LevelText>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.LevelPictureBulletId>();
      if (element != null)
        return LevelPictureBulletIdConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.LevelPictureBulletId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LevelPictureBulletIdConverter.CreateOpenXmlElement<DXW.LevelPictureBulletId>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.LegacyNumbering>();
      if (element != null)
        return LegacyNumberingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.LegacyNumbering>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LegacyNumberingConverter.CreateOpenXmlElement<DXW.LegacyNumbering>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.PreviousParagraphProperties>();
      if (element != null)
        return PreviousParagraphPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PreviousParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PreviousParagraphPropertiesConverter.CreateOpenXmlElement<DXW.PreviousParagraphProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.NumberingSymbolRunProperties>();
      if (element != null)
        return NumberingSymbolRunPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NumberingSymbolRunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingSymbolRunPropertiesConverter.CreateOpenXmlElement<DXW.NumberingSymbolRunProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
