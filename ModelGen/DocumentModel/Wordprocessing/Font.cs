namespace DocumentModel.Wordprocessing;


/// <summary>
///   Properties for a Single Font.
/// </summary>
public partial class Font: ModelElement<DXW.Font>
{
  public Font(): base(){ }
  
  public Font(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Font(DXW.Font openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   name
  /// </summary>
  [DataMember]
  public String? Name
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Name);
    }
    set
    {
      _ExistingElement.Name = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   AltName.
  /// </summary>
  [DataMember]
  public DMW.AltName? AltName
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.AltName>();
      if (element != null)
        return AltNameConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AltName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AltNameConverter.CreateOpenXmlElement<DXW.AltName>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Panose1Number.
  /// </summary>
  [DataMember]
  public DM.HexBinary? Panose1Number
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Panose1Number>();
      if (element != null)
        return DMX.HexBinaryConverter.GetValue(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Panose1Number>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HexBinaryConverter.CreateOpenXmlElement<DXW.Panose1Number>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   FontCharSet.
  /// </summary>
  [DataMember]
  public DMW.FontCharSet? FontCharSet
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.FontCharSet>();
      if (element != null)
        return FontCharSetConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FontCharSet>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FontCharSetConverter.CreateOpenXmlElement<DXW.FontCharSet>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   FontFamily.
  /// </summary>
  [DataMember]
  public DMW.FontFamilyKind? FontFamily
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues, DMW.FontFamilyKind>(_ExistingElement.GetFirstChild<DXW.FontFamily>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FontFamily>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues, DMW.FontFamilyKind>(itemElement, (DMW.FontFamilyKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.FontFamily, DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues, DMW.FontFamilyKind>((DMW.FontFamilyKind)value));
    }
  }
  
  
  /// <summary>
  ///   NotTrueType.
  /// </summary>
  [DataMember]
  public DMW.NotTrueType? NotTrueType
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.NotTrueType>();
      if (element != null)
        return NotTrueTypeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NotTrueType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NotTrueTypeConverter.CreateOpenXmlElement<DXW.NotTrueType>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Pitch.
  /// </summary>
  [DataMember]
  public DMW.FontPitchKind? Pitch
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FontPitchValues, DMW.FontPitchKind>(_ExistingElement.GetFirstChild<DXW.Pitch>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Pitch>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FontPitchValues, DMW.FontPitchKind>(itemElement, (DMW.FontPitchKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.Pitch, DocumentFormat.OpenXml.Wordprocessing.FontPitchValues, DMW.FontPitchKind>((DMW.FontPitchKind)value));
    }
  }
  
  
  /// <summary>
  ///   FontSignature.
  /// </summary>
  [DataMember]
  public DMW.FontSignature? FontSignature
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.FontSignature>();
      if (element != null)
        return FontSignatureConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FontSignature>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FontSignatureConverter.CreateOpenXmlElement<DXW.FontSignature>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   EmbedRegularFont.
  /// </summary>
  [DataMember]
  public DMW.EmbedRegularFont? EmbedRegularFont
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.EmbedRegularFont>();
      if (element != null)
        return EmbedRegularFontConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.EmbedRegularFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EmbedRegularFontConverter.CreateOpenXmlElement<DXW.EmbedRegularFont>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   EmbedBoldFont.
  /// </summary>
  [DataMember]
  public DMW.EmbedBoldFont? EmbedBoldFont
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.EmbedBoldFont>();
      if (element != null)
        return EmbedBoldFontConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.EmbedBoldFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EmbedBoldFontConverter.CreateOpenXmlElement<DXW.EmbedBoldFont>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   EmbedItalicFont.
  /// </summary>
  [DataMember]
  public DMW.EmbedItalicFont? EmbedItalicFont
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.EmbedItalicFont>();
      if (element != null)
        return EmbedItalicFontConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.EmbedItalicFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EmbedItalicFontConverter.CreateOpenXmlElement<DXW.EmbedItalicFont>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   EmbedBoldItalicFont.
  /// </summary>
  [DataMember]
  public DMW.EmbedBoldItalicFont? EmbedBoldItalicFont
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.EmbedBoldItalicFont>();
      if (element != null)
        return EmbedBoldItalicFontConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.EmbedBoldItalicFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EmbedBoldItalicFontConverter.CreateOpenXmlElement<DXW.EmbedBoldItalicFont>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
