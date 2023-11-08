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
      var element = _Element?.GetFirstChild<DXW.PhoneticGuideTextFontSize>();
      if (element != null)
        return PhoneticGuideTextFontSizeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PhoneticGuideTextFontSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PhoneticGuideTextFontSizeConverter.CreateOpenXmlElement<DXW.PhoneticGuideTextFontSize>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      SimpleValueConverter.SetValue<DXW.PhoneticGuideRaise,System.Int16>(openXmlElement, value);
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
      var element = _Element?.GetFirstChild<DXW.PhoneticGuideBaseTextSize>();
      if (element != null)
        return PhoneticGuideBaseTextSizeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PhoneticGuideBaseTextSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PhoneticGuideBaseTextSizeConverter.CreateOpenXmlElement<DXW.PhoneticGuideBaseTextSize>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      StringValueConverter.SetValue<DXW.LanguageId>(openXmlElement, value);
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
      var element = _Element?.GetFirstChild<DXW.Dirty>();
      if (element != null)
        return DirtyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Dirty>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DirtyConverter.CreateOpenXmlElement<DXW.Dirty>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
