namespace DocxDocument.Model;

public class RunProperties
{
  [XmlIgnore]
  [JsonIgnore]
  public Document? Document { get; set; }

  #region FontNames
  /// <summary> 
  /// Nazwa czcionki
  ///</summary> 
  public string? FontName
  {
    get => FontNames?.Name ?? _FontName;
    set
    {
      _FontName = value;
      if (FontNames != null)
        FontNames.Name = value;
    }
  }
  private string? _FontName;

  /// <summary> 
  /// Nazwa czcionki wg motywu
  ///</summary> 
  public string? FontThemeName
  {
    get => FontNames?.ThemeName ?? _FontThemeName;
    set
    {
      _FontThemeName = value;
      if (FontNames != null)
        FontNames.ThemeName = value;
    }
  }
  private string? _FontThemeName;

  /// <summary> 
  /// Nazwy czcionki dla różnych grup pisma
  ///</summary>
  public FontNames? FontNames { get; set; }

  public bool ShouldSerializeFontNames()
  {
    return FontNames != null && (FontNames.HasSomeNameDifferent(FontName) || FontNames.HasSomeThemeNameDifferent(FontThemeName));
  }
  #endregion

  /// <summary> 
  /// Rozmiar czcionki w punktach.
  ///</summary>
  public decimal? FontSize { get; set; }

  /// <summary> 
  /// Rozmiar czcionki w dla języków RTL
  ///</summary> 
  public decimal? FontSizeBi { get; set; }

  /// <summary> 
  /// Wytłuszczenie
  ///</summary> 
  public bool? Bold { get; set; }

  /// <summary> 
  /// Wytłuszczenie dla języków RTL
  ///</summary> 
  public bool? BoldBi { get; set; }

  /// <summary> 
  /// Pochylenie (kursywa)
  ///</summary> 
  public bool? Italic { get; set; }

  /// <summary> 
  /// Kursywa dla języków RTL
  ///</summary> 
  public bool? ItalicBi { get; set; }

  /// <summary> 
  /// Podkreślenie
  ///</summary> 
  public Underline? Underline { get; set; }

  /// <summary> 
  /// Kolor podkreślenia
  ///</summary> 
  public Color? UnderlineColor { get; set; }

  /// <summary> 
  /// Przekreślenie pojedyncze. Wyklucza przekreślenie podwójne.
  ///</summary> 
  public bool? StrikeThrough { get; set; }

  /// <summary> 
  /// Przekreślenie podwójne. Wyklucza przekreślenie pojedyncze.
  ///</summary> 
  public bool? DoubleStrike­­Through { get; set; }

  /// <summary> 
  /// Indeksowanie dolne. Wyklucza indeksowanie górne.
  ///</summary> 
  public bool? Subscript { get; set; }

  /// <summary> 
  /// Indeksowanie górne. Wyklucza indeksowanie dolne.
  ///</summary> 
  public bool? Superscript { get; set; }

  /// <summary> 
  /// Wszystkie litery  wyświetlane jako wielkie. Wyklucza SmallCaps.
  ///</summary> 
  public bool? AllCaps { get; set; }

  /// <summary> 
  /// Małe litery wyświetlane jak wielkie ale nieco mniejsze. Wyklucza AllCaps.
  ///</summary> 
  public bool? SmallCaps { get; set; }

  #region Languages
  /// <summary> 
  /// Język sprawdzania
  ///</summary> 
  public string? Lang
  {
    get => Languages?.Name ?? _Lang;
    set
    {
      _Lang = value;
      if (Languages != null)
        Languages.Name = value;
    }
  }
  private string? _Lang;

  /// <summary>
  /// Languages to select for specific script type
  /// </summary>
  public Languages? Languages { get; set; }

  public bool ShouldSerializeLanguages()
  {
    return Languages != null && Languages.HasSomeNameDifferent(Lang);
  }
  #endregion

  /// <summary> 
  /// Tekst ukryty.
  ///</summary> 
  public bool? Hidden { get; set; }

  /// <summary> 
  /// Tekst ukryty na stronie Web.
  ///</summary> 
  public bool? WebHidden { get; set; }

  /// <summary> 
  /// Znak ukrytego akapitu nie jest używany do łamania tekstu.
  /// Używany tylko do właściwości znaczników akapitu
  ///</summary> 
  public bool? SpecHidden { get; set; }

  /// <summary> 
  /// Podaje obiekt ColorFormat dla ustalenia koloru tekstu. Obiekt ColorFormat umożliwia ustawienie koloru dla tekstu, dla tła, dla linii, dla cienia i dla wytłoczenia.
  ///</summary> 
  public ColorFormat? TextColor { get; set; }

  /// <summary> 
  /// Ustawia kolor indeksowany dla tekstu.
  ///</summary> 
  public ColorIndex? ColorIndex { get; set; }

  /// <summary> 
  /// Ustawia kolor indeksowany dla tekstu w językach RTL.
  ///</summary> 
  public ColorIndex? ColorIndexBi { get; set; }

  /// <summary> 
  /// Ustala kolor znaków diakrytycznych. Działa, jeśli jest ustalona właściwość UseDiffDiacColor.
  ///</summary> 
  public Color? DiacriticColor { get; set; }

  /// <summary> 
  /// Ustala odstępy międzyznakowe w punktach
  ///</summary> 
  public float? Spacing { get; set; }

  /// <summary> 
  /// Ustala poziome skalowanie czcionek w procentach. Czcionki mogą być zwężone lub rozszerzone. Zakres od 1 do 600.
  ///</summary> 
  public int? Scaling { get; set; }

  /// <summary> 
  /// Zmienia pionowe położenie tekstu względem linii bazowej (w punktach)
  ///</summary> 
  public int? Position { get; set; }

  /// <summary> 
  /// Podaje minimalny rozmiar czcionki (w punktach), poniżej którego stosuje się automatyczne podsuwanie znaków.
  ///</summary> 
  public float? Kerning { get; set; }

  /// <summary> 
  /// Nakazuje ignorowanie ustalonej w siatce dokumentu liczby znaków w linii.
  ///</summary> 
  public bool? DisableCharacter­SpaceGrid { get; set; }

  /// <summary> 
  /// Wyświetla obwiednię zamiast wypełnienia znaków
  ///</summary> 
  public bool? Outline { get; set; }

  /// <summary> 
  /// Wyświetla tekst jak wytłoczony. Wyklucza Engrave.
  ///</summary> 
  public bool? Emboss { get; set; }

  /// <summary> 
  /// Wyświetla tekst jak wygrawerowany. Wyklucza Emboss.
  ///</summary> 
  public bool? Engrave { get; set; }

  /// <summary> 
  /// Wyświetla specjalny znak zwrócenia uwagi.
  ///</summary> 
  public Emphasis­Mark? EmphasisMark { get; set; }

  /// <summary> 
  /// Podaje właściwości cieniowania tekstu.
  ///</summary> 
  public Shading? Shading { get; set; }

  /// <summary> 
  /// Ustala format cienia dla tekstu.
  ///</summary> 
  public Shadow­Format? TextShadow { get; set; }

  /// <summary> 
  /// Umożliwia ustalenie obramowania tekstu
  ///</summary> 
  public RunBorders? Borders { get; set; }

}