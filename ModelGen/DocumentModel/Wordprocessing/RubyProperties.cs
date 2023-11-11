namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of properties which determine the behavior and appearance of a phonetic guide within the document.
/// </summary>
public partial class RubyProperties: ModelElement<DXW.RubyProperties>
{
  public RubyProperties(): base(){ }
  
  public RubyProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RubyProperties(DXW.RubyProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Phonetic Guide Text Alignment.
  /// </summary>
  [DataMember]
  public DMW.RubyAlignKind? RubyAlign
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues, DMW.RubyAlignKind>(_ExistingElement.GetFirstChild<DXW.RubyAlign>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RubyAlign>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues, DMW.RubyAlignKind>(itemElement, (DMW.RubyAlignKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.RubyAlign, DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues, DMW.RubyAlignKind>((DMW.RubyAlignKind)value));
    }
  }
  
  
  /// <summary>
  ///   Phonetic Guide Text Font Size.
  /// </summary>
  [DataMember]
  public DMW.PhoneticGuideTextFontSize? PhoneticGuideTextFontSize
  {
    get
    {
      return _Element?.GetObject<DMW.PhoneticGuideTextFontSize,DXW.PhoneticGuideTextFontSize>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PhoneticGuideTextFontSize,DXW.PhoneticGuideTextFontSize>(value);
    }
  }
  
  
  /// <summary>
  ///   Distance Between Phonetic Guide Text and Phonetic Guide Base Text.
  /// </summary>
  [DataMember]
  public Int16? PhoneticGuideRaise
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXW.PhoneticGuideRaise>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXW.PhoneticGuideRaise,System.Int16>(_ExistingElement, value);
    }
  }
  
  
  /// <summary>
  ///   Phonetic Guide Base Text Font Size.
  /// </summary>
  [DataMember]
  public DMW.PhoneticGuideBaseTextSize? PhoneticGuideBaseTextSize
  {
    get
    {
      return _Element?.GetObject<DMW.PhoneticGuideBaseTextSize,DXW.PhoneticGuideBaseTextSize>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PhoneticGuideBaseTextSize,DXW.PhoneticGuideBaseTextSize>(value);
    }
  }
  
  
  /// <summary>
  ///   Language ID for Phonetic Guide.
  /// </summary>
  [DataMember]
  public String? LanguageId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetFirstChild<DXW.LanguageId>()?.Val);
    }
    set
    {
      StringValueConverter.SetValue<DXW.LanguageId>(_ExistingElement, value);
    }
  }
  
  
  /// <summary>
  ///   Invalidated Field Cache.
  /// </summary>
  [DataMember]
  public DMW.Dirty? Dirty
  {
    get
    {
      return _Element?.GetObject<DMW.Dirty,DXW.Dirty>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Dirty,DXW.Dirty>(value);
    }
  }
  
}
