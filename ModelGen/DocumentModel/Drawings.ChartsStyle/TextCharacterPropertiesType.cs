namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the TextCharacterPropertiesType Class.
/// </summary>
public partial class TextCharacterPropertiesType: ModelElement<DXO13DCS.TextCharacterPropertiesType>
{
  public TextCharacterPropertiesType(): base(){ }
  
  public TextCharacterPropertiesType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextCharacterPropertiesType(DXO13DCS.TextCharacterPropertiesType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   kumimoji
  /// </summary>
  [DataMember]
  public Boolean? Kumimoji
  {
    get => _Element?.Kumimoji?.Value;
    set => _ExistingElement.Kumimoji = value;
  }
  
  
  /// <summary>
  ///   lang
  /// </summary>
  [DataMember]
  public String? Language
  {
    get => _Element?.Language;
    set => _ExistingElement.Language = value;
  }
  
  
  /// <summary>
  ///   altLang
  /// </summary>
  [DataMember]
  public String? AlternativeLanguage
  {
    get => _Element?.AlternativeLanguage;
    set => _ExistingElement.AlternativeLanguage = value;
  }
  
  
  /// <summary>
  ///   sz
  /// </summary>
  [DataMember]
  public Int32? FontSize
  {
    get => _Element?.FontSize?.Value;
    set => _ExistingElement.FontSize = value;
  }
  
  
  /// <summary>
  ///   b
  /// </summary>
  [DataMember]
  public Boolean? Bold
  {
    get => _Element?.Bold?.Value;
    set => _ExistingElement.Bold = value;
  }
  
  
  /// <summary>
  ///   i
  /// </summary>
  [DataMember]
  public Boolean? Italic
  {
    get => _Element?.Italic?.Value;
    set => _ExistingElement.Italic = value;
  }
  
  
  /// <summary>
  ///   kern
  /// </summary>
  [DataMember]
  public Int32? Kerning
  {
    get => _Element?.Kerning?.Value;
    set => _ExistingElement.Kerning = value;
  }
  
  
  /// <summary>
  ///   spc
  /// </summary>
  [DataMember]
  public Int32? Spacing
  {
    get => _Element?.Spacing?.Value;
    set => _ExistingElement.Spacing = value;
  }
  
  
  /// <summary>
  ///   normalizeH
  /// </summary>
  [DataMember]
  public Boolean? NormalizeHeight
  {
    get => _Element?.NormalizeHeight?.Value;
    set => _ExistingElement.NormalizeHeight = value;
  }
  
  
  /// <summary>
  ///   baseline
  /// </summary>
  [DataMember]
  public Int32? Baseline
  {
    get => _Element?.Baseline?.Value;
    set => _ExistingElement.Baseline = value;
  }
  
  
  /// <summary>
  ///   noProof
  /// </summary>
  [DataMember]
  public Boolean? NoProof
  {
    get => _Element?.NoProof?.Value;
    set => _ExistingElement.NoProof = value;
  }
  
  
  /// <summary>
  ///   dirty
  /// </summary>
  [DataMember]
  public Boolean? Dirty
  {
    get => _Element?.Dirty?.Value;
    set => _ExistingElement.Dirty = value;
  }
  
  
  /// <summary>
  ///   err
  /// </summary>
  [DataMember]
  public Boolean? SpellingError
  {
    get => _Element?.SpellingError?.Value;
    set => _ExistingElement.SpellingError = value;
  }
  
  
  /// <summary>
  ///   smtClean
  /// </summary>
  [DataMember]
  public Boolean? SmartTagClean
  {
    get => _Element?.SmartTagClean?.Value;
    set => _ExistingElement.SmartTagClean = value;
  }
  
  
  /// <summary>
  ///   smtId
  /// </summary>
  [DataMember]
  public UInt32? SmartTagId
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   bmk
  /// </summary>
  [DataMember]
  public String? Bookmark
  {
    get => _Element?.Bookmark;
    set => _ExistingElement.Bookmark = value;
  }
  
  
  /// <summary>
  ///   Outline.
  /// </summary>
  [DataMember]
  public DMD.Outline? Outline
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.LinePropertiesType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.LinePropertiesType");
  }
  
}
