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
      return _Element?.GetObject<DMW.AltName,DXW.AltName>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AltName,DXW.AltName>(value);
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
      return _Element?.GetObject<DM.HexBinary,DXW.Panose1Number>();
    }
    set
    {
      _ExistingElement.SetObject<DM.HexBinary,DXW.Panose1Number>(value);
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
      return _Element?.GetObject<DMW.FontCharSet,DXW.FontCharSet>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FontCharSet,DXW.FontCharSet>(value);
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
      return _Element?.GetObject<DMW.NotTrueType,DXW.NotTrueType>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NotTrueType,DXW.NotTrueType>(value);
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
      return _Element?.GetObject<DMW.FontSignature,DXW.FontSignature>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FontSignature,DXW.FontSignature>(value);
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
      return _Element?.GetObject<DMW.EmbedRegularFont,DXW.EmbedRegularFont>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.EmbedRegularFont,DXW.EmbedRegularFont>(value);
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
      return _Element?.GetObject<DMW.EmbedBoldFont,DXW.EmbedBoldFont>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.EmbedBoldFont,DXW.EmbedBoldFont>(value);
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
      return _Element?.GetObject<DMW.EmbedItalicFont,DXW.EmbedItalicFont>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.EmbedItalicFont,DXW.EmbedItalicFont>(value);
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
      return _Element?.GetObject<DMW.EmbedBoldItalicFont,DXW.EmbedBoldItalicFont>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.EmbedBoldItalicFont,DXW.EmbedBoldItalicFont>(value);
    }
  }
  
}
