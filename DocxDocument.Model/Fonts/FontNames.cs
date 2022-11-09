using DocxDocument.Model.Drawing;

namespace DocxDocument.Model;

public class FontNames
{
  [XmlIgnore]
  [JsonIgnore]
  public FontScheme? FontScheme { get; set; }

  [XmlAttribute]
  public string? Ascii
  {
    get => ThemeFont(AsciiTheme) ?? _Ascii;
    set => _Ascii = value;
  }
  private string? _Ascii;

  [XmlAttribute]
  public string? ComplexScript
  {
    get => ThemeFont(ComplexScriptTheme) ?? _ComplexScript;
    set => _ComplexScript = value;
  }
  private string? _ComplexScript;

  [XmlAttribute]
  public string? EastAsia
  {
    get => ThemeFont(EastAsiaTheme) ?? _EastAsia;
    set => _EastAsia = value;
  }
  private string? _EastAsia;

  [XmlAttribute]
  public string? HighAnsi
  {
    get => ThemeFont(HighAnsiTheme) ?? _HighAnsi;
    set => _HighAnsi = value;
  }
  private string? _HighAnsi;

  [XmlAttribute]
  public string? AsciiTheme { get; set; }

  [XmlAttribute]
  public string? ComplexScriptTheme { get; set; }

  [XmlAttribute]
  public string? EastAsiaTheme { get; set; }

  [XmlAttribute]
  public string? HighAnsiTheme { get; set; }

  [XmlAttribute]
  public FontTypeHint? Hint { get; set;}

  [XmlIgnore]
  [JsonIgnore]
  public string? Name
  {
    get
    {
      if (Hint != null)
        switch ((FontTypeHint)Hint)
        {
          case FontTypeHint.Default:
            return HighAnsi ?? Ascii;
          case FontTypeHint.ComplexScript:
            return ComplexScript;
          case FontTypeHint.EastAsia:
            return EastAsia;
        }
      return Ascii ?? HighAnsi ?? ComplexScript ?? EastAsia;
    }
    set
    {
      if (Hint != null)
        switch ((FontTypeHint)Hint)
        {
          case FontTypeHint.Default:
            HighAnsi = value;
            Ascii = value;
            return;
          case FontTypeHint.ComplexScript:
            ComplexScript = value;
            return;
          case FontTypeHint.EastAsia:
            EastAsia = value;
            return;
        }
      Ascii = value;
      ComplexScript = value;
      EastAsia = value;
      HighAnsi = value;
    }
  }

  [XmlIgnore]
  [JsonIgnore]
  public string? ThemeName
  {
    get
    {
      if (Hint != null)
        switch ((FontTypeHint)Hint)
        {
          case FontTypeHint.Default:
            return HighAnsiTheme ?? AsciiTheme;
          case FontTypeHint.ComplexScript:
            return ComplexScriptTheme;
          case FontTypeHint.EastAsia:
            return EastAsiaTheme;
        }
      return AsciiTheme ?? HighAnsiTheme ?? ComplexScriptTheme ?? EastAsiaTheme;
    }
    set
    {
      if (Hint != null)
        switch ((FontTypeHint)Hint)
        {
          case FontTypeHint.Default:
            HighAnsiTheme = value;
            AsciiTheme = value;
            return;
          case FontTypeHint.ComplexScript:
            ComplexScriptTheme = value;
            return;
          case FontTypeHint.EastAsia:
            EastAsiaTheme = value;
            return;
        }
      HighAnsiTheme = value;
      Ascii = value;
      ComplexScriptTheme = value;
      EastAsiaTheme = value;
    }
  }

  private string? ThemeFont(string? themeFontName)
  {
    if (FontScheme != null && themeFontName != null)
    {
      switch (themeFontName)
      {
        case "MajorAscii":
        case "MajorHighAnsi":
          return FontScheme?.MajorFont?.LatinFont?.Typeface;
        case "MajorBidi":
          return FontScheme?.MajorFont?.ComplexScriptFont?.Typeface;
        case "MajorEastAsia":
          return FontScheme?.MajorFont?.EastAsianFont?.Typeface;

        case "MinorAscii":
        case "MinorHighAnsi":
          return FontScheme?.MinorFont?.LatinFont?.Typeface;
        case "MinorBidi":
          return FontScheme?.MinorFont?.ComplexScriptFont?.Typeface;
        case "MinorEastAsia":
          return FontScheme?.MinorFont?.EastAsianFont?.Typeface;
      }
    }
    return null;
  }

  public bool HasSomeNameDifferent(string? aName)
  {
    if (Ascii!=null && Ascii!=aName)
      return true;
    if (ComplexScript != null && ComplexScript != aName)
      return true;
    if (EastAsia != null && EastAsia != aName)
      return true;
    if (HighAnsi != null && HighAnsi != aName)
      return true;
    return false;
  }

  public bool HasSomeThemeNameDifferent(string? aName)
  {
    if (AsciiTheme != null && AsciiTheme != aName)
      return true;
    if (ComplexScriptTheme != null && ComplexScriptTheme != aName)
      return true;
    if (EastAsiaTheme != null && EastAsiaTheme != aName)
      return true;
    if (HighAnsiTheme != null && HighAnsiTheme != aName)
      return true;
    return false;
  }
}