using Microsoft.Office.Interop.Word;

namespace DocxDocument.Model;

public interface IRunProperties: IFont
{

  /// <summary> 
  /// Podkreślenie
  ///</summary> 
  Underline? Underline { get; set; }

  /// <summary> 
  /// Kolor podkreślenia
  ///</summary> 
  Color? UnderlineColor { get; set; }

  /// <summary> 
  /// Przekreślenie pojedyncze. Wyklucza przekreślenie podwójne.
  ///</summary> 
  bool? StrikeThrough { get; set; }

  /// <summary> 
  /// Przekreślenie podwójne. Wyklucza przekreślenie pojedyncze.
  ///</summary> 
  bool? DoubleStrike­­Through { get; set; }

  /// <summary> 
  /// Indeksowanie dolne. Wyklucza indeksowanie górne.
  ///</summary> 
  bool? Subscript { get; set; }

  /// <summary> 
  /// Indeksowanie górne. Wyklucza indeksowanie dolne.
  ///</summary> 
  bool? Superscript { get; set; }

  /// <summary> 
  /// Wszystkie litery  wyświetlane jako wielkie. Wyklucza SmallCaps.
  ///</summary> 
  bool? AllCaps { get; set; }

  /// <summary> 
  /// Małe litery wyświetlane jak wielkie ale nieco mniejsze. Wyklucza AllCaps.
  ///</summary> 
  bool? SmallCaps { get; set; }

  /// <summary> 
  /// Język sprawdzania
  ///</summary> 
  string? Lang { get; set; }

  /// <summary> 
  /// Tekst ukryty.
  ///</summary> 
  bool? Hidden { get; set; }

  /// <summary> 
  /// Tekst ukryty na stronie Web.
  ///</summary> 
  bool? WebHidden { get; set; }

  /// <summary> 
  /// Znak ukrytego akapitu nie jest używany do łamania tekstu.
  /// Używany tylko do właściwości znaczników akapitu
  ///</summary> 
  bool? SpecHidden { get; set; }

  /// <summary> 
  /// Podaje obiekt ColorFormat dla ustalenia koloru tekstu. Obiekt ColorFormat umożliwia ustawienie koloru dla tekstu, dla tła, dla linii, dla cienia i dla wytłoczenia.
  ///</summary> 
  ColorFormat? TextColor { get; set; }

  /// <summary> 
  /// Ustawia kolor indeksowany dla tekstu.
  ///</summary> 
  WdColorIndex? ColorIndex { get; set; }

  /// <summary> 
  /// Ustawia kolor indeksowany dla tekstu w językach RTL.
  ///</summary> 
  WdColorIndex? ColorIndexBi { get; set; }

  /// <summary> 
  /// Ustala kolor znaków diakrytycznych. Działa, jeśli jest ustalona właściwość UseDiffDiacColor.
  ///</summary> 
  Color? DiacriticColor { get; set; }

  /// <summary> 
  /// Ustala odstępy międzyznakowe w punktach
  ///</summary> 
  float? Spacing { get; set; }

  /// <summary> 
  /// Ustala poziome skalowanie czcionek w procentach. Czcionki mogą być zwężone lub rozszerzone. Zakres od 1 do 600.
  ///</summary> 
  int? Scaling { get; set; }

  /// <summary> 
  /// Zmienia pionowe położenie tekstu względem linii bazowej (w punktach)
  ///</summary> 
  int Position { get; set; }

  /// <summary> 
  /// Podaje minimalny rozmiar czcionki (w punktach), poniżej którego stosuje się automatyczne podsuwanie znaków.
  ///</summary> 
  float? Kerning { get; set; }

  /// <summary> 
  /// Nakazuje ignorowanie ustalonej w siatce dokumentu liczby znaków w linii.
  ///</summary> 
  bool? DisableCharacter­SpaceGrid { get; set; }

  /// <summary> 
  /// Wyświetla obwiednię zamian wypełnienia znaków
  ///</summary> 
  bool? Outline { get; set; }

  /// <summary> 
  /// Wyświetla tekst jak wytłoczony. Wyklucza Engrave.
  ///</summary> 
  bool? Emboss { get; set; }

  /// <summary> 
  /// Wyświetla tekst jak wygrawerowany. Wyklucza Emboss.
  ///</summary> 
  bool? Engrave { get; set; }

  /// <summary> 
  /// Wyświetla specjalny znak zwrócenia uwagi.
  ///</summary> 
  WdEmphasis­Mark? EmphasisMark { get; set; }

  /// <summary> 
  /// Podaje właściwości cieniowania tekstu.
  ///</summary> 
  Shading? Shading { get; set; }

  /// <summary> 
  /// Ustala format cienia dla tekstu.
  ///</summary> 
  Shadow­Format? TextShadow { get; set; }

  /// <summary> 
  /// Umożliwia ustalenie obramowania tekstu
  ///</summary> 
  RunBorders? Borders { get; set; }


}