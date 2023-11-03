namespace DocumentModel.Wordprocessing;

  /// <summary>
  ///  This class specifies the language which shall be used to determine the appropriate theme fonts 
  ///  in the document's Theme part which map to the major/minor theme fonts. 
  ///  Specifically, the bidi attribute is used to determine the theme font applied to complex script text, 
  ///  the eastAsia attribute is used to determine the theme font applied to East Asian text, 
  ///  and the val attribute is used to determine the theme font applied to all other text.
  /// <para>
  /// These mappings are performed as follows:
  /// </para>
  /// <list type="bullet">
  ///   <item>
  ///     For majorAscii/majorHAnsi, locate the font element (§20.1.4.1.16) in the majorFont element (§20.1.4.1.24) 
  ///     in the theme part for the language specified by the val attribute
  ///   </item>
  ///   <item>
  ///     For majorBidi, locate the font element in the majorFont element in the theme part for the language specified by the bidi attribute
  ///   </item>
  ///   <item>
  ///     For majorEastAsia, locate the font element in the majorFont element in the theme part for the language specified by the eastAsia attribute
  ///   </item>
  ///   <item>
  ///     For minorAscii/minorHAnsi, locate the font element in the minorFont element (§20.1.4.1.25) 
  ///     in the theme part for the language specified by the val attribute
  ///   </item>
  ///   <item>
  ///     For minorBidi, locate the font element in the minorFont element in the theme part for the language specified by the bidi attribute
  ///   </item>
  ///   <item>
  ///     For minorEastAsia, locate the font element in the minorFont element in the theme part for the language specified by the eastAsia attribute
  ///   </item>
  /// </list>
  /// <para>
  ///   If this element is omitted, then the default fonts for each region as specified by the latin, ea, and cs elements 
  ///   (§21.1.2.3.7; §21.1.2.3.3; §21.1.2.3.1) should be used.
  /// </para>
  /// </summary>
[DataContract]
public partial class LanguageType: IOpenXmlElementMappedObject
{
  public LanguageType()
  {
    _Element = new DXW.Languages();
  }

  public LanguageType(DX.OpenXmlElement openXmlElement)
  {
    if (openXmlElement is DXW.Languages languages)
      _Element = languages;
    else
    if (openXmlElement is DXW.ThemeFontLanguages themeFontLanguages)
    {
      _Element = themeFontLanguages;
    }
    else
      throw new InvalidOperationException($"SourceElement must be of Languages or ThemeFontLanguages type");

  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType : DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType languages)
      return languages;
    DXW.LanguageType result;
    if (typeof(OpenXmlElementType) == typeof(DXW.Languages))
      result = new DXW.Languages();
    else
    if (typeof(OpenXmlElementType) == typeof(DXW.ThemeFontLanguages))
      result = new DXW.ThemeFontLanguages();
    else
      throw new InvalidOperationException($"Element type {typeof(OpenXmlElementType)} not supported");

    result.Val = Val;
    result.Bidi = Bidi;
    result.EastAsia = EastAsia;
    if (result is OpenXmlElementType obj)
      return obj;

    throw new InvalidOperationException($"Element type {typeof(OpenXmlElementType)} not supported");
  }

  public LanguageType(DXW.LanguageType openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.LanguageType _Element { get; private set; }

  [DataMember]
  public string? Val
  {
    get => _Element.Val;
    set => _Element.Val = value;
  }

  [DataMember]
  public string? Bidi
  {
    get => _Element.Bidi;
    set => _Element.Bidi = value;
  }

  [DataMember]
  public string? EastAsia
  {
    get => _Element.EastAsia;
    set => _Element.EastAsia = value;
  }

}
