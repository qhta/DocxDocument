namespace DocumentModel.Drawings;


/// <summary>
///   Defines the TextCharacterPropertiesType Class.
/// </summary>
public partial class TextCharacterPropertiesType: ModelElement<DXD.TextCharacterPropertiesType>
{
  public TextCharacterPropertiesType(): base(){ }
  
  public TextCharacterPropertiesType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextCharacterPropertiesType(DXD.TextCharacterPropertiesType openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public Boolean? SmtClean
  {
    get
    {
      return _Element?.SmtClean?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.SmtClean = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.SmtClean = null;
    }
  }
  
  [DataMember]
  public UInt32? SmtId
  {
    get
    {
      return _Element?.SmtId?.Value;
    }
    set
    {
      _ExistingElement.SmtId = value;
    }
  }
  
  
  /// <summary>
  ///   kumimoji
  /// </summary>
  [DataMember]
  public Boolean? Kumimoji
  {
    get
    {
      return _Element?.Kumimoji?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Kumimoji = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Kumimoji = null;
    }
  }
  
  
  /// <summary>
  ///   lang
  /// </summary>
  [DataMember]
  public String? Language
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Language);
    }
    set
    {
      _ExistingElement.Language = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   altLang
  /// </summary>
  [DataMember]
  public String? AlternativeLanguage
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.AlternativeLanguage);
    }
    set
    {
      _ExistingElement.AlternativeLanguage = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   sz
  /// </summary>
  [DataMember]
  public Int32? FontSize
  {
    get
    {
      return _Element?.FontSize?.Value;
    }
    set
    {
      _ExistingElement.FontSize = value;
    }
  }
  
  
  /// <summary>
  ///   b
  /// </summary>
  [DataMember]
  public Boolean? Bold
  {
    get
    {
      return _Element?.Bold?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Bold = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Bold = null;
    }
  }
  
  
  /// <summary>
  ///   i
  /// </summary>
  [DataMember]
  public Boolean? Italic
  {
    get
    {
      return _Element?.Italic?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Italic = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Italic = null;
    }
  }
  
  
  /// <summary>
  ///   kern
  /// </summary>
  [DataMember]
  public Int32? Kerning
  {
    get
    {
      return _Element?.Kerning?.Value;
    }
    set
    {
      _ExistingElement.Kerning = value;
    }
  }
  
  
  /// <summary>
  ///   spc
  /// </summary>
  [DataMember]
  public Int32? Spacing
  {
    get
    {
      return _Element?.Spacing?.Value;
    }
    set
    {
      _ExistingElement.Spacing = value;
    }
  }
  
  
  /// <summary>
  ///   normalizeH
  /// </summary>
  [DataMember]
  public Boolean? NormalizeHeight
  {
    get
    {
      return _Element?.NormalizeHeight?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.NormalizeHeight = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NormalizeHeight = null;
    }
  }
  
  
  /// <summary>
  ///   baseline
  /// </summary>
  [DataMember]
  public Int32? Baseline
  {
    get
    {
      return _Element?.Baseline?.Value;
    }
    set
    {
      _ExistingElement.Baseline = value;
    }
  }
  
  
  /// <summary>
  ///   noProof
  /// </summary>
  [DataMember]
  public Boolean? NoProof
  {
    get
    {
      return _Element?.NoProof?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.NoProof = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoProof = null;
    }
  }
  
  
  /// <summary>
  ///   dirty
  /// </summary>
  [DataMember]
  public Boolean? Dirty
  {
    get
    {
      return _Element?.Dirty?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Dirty = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Dirty = null;
    }
  }
  
  
  /// <summary>
  ///   err
  /// </summary>
  [DataMember]
  public Boolean? SpellingError
  {
    get
    {
      return _Element?.SpellingError?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.SpellingError = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.SpellingError = null;
    }
  }
  
  
  /// <summary>
  ///   smtClean
  /// </summary>
  [DataMember]
  public Boolean? SmartTagClean
  {
    get
    {
      return _Element?.SmartTagClean?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.SmartTagClean = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.SmartTagClean = null;
    }
  }
  
  
  /// <summary>
  ///   smtId
  /// </summary>
  [DataMember]
  public UInt32? SmartTagId
  {
    get
    {
      return _Element?.SmartTagId?.Value;
    }
    set
    {
      _ExistingElement.SmartTagId = value;
    }
  }
  
  
  /// <summary>
  ///   bmk
  /// </summary>
  [DataMember]
  public String? Bookmark
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Bookmark);
    }
    set
    {
      _ExistingElement.Bookmark = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Outline.
  /// </summary>
  [DataMember]
  public DMD.Outline? Outline
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Outline>();
      if (element != null)
        return OutlineConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Outline>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OutlineConverter.CreateOpenXmlElement<DXD.Outline>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
