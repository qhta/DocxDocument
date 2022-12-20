namespace DocxDocument.Model;

public interface IFont
{
  /// <summary> 
  /// Nazwa czcionki
  ///</summary> 
  string? FontName { get; set; }

  /// <summary> 
  /// Rozmiar czcionki w punktach.
  ///</summary> 
  float? FontSize { get; set; }

  /// <summary> 
  /// Rozmiar czcionki w dla języków RTL
  ///</summary> 
  float? FontSizeBi { get; set; }

  /// <summary> 
  /// Wytłuszczenie
  ///</summary> 
  bool? Bold { get; set; }

  /// <summary> 
  /// Wytłuszczenie dla języków RTL
  ///</summary> 
  bool? BoldBi { get; set; }

  /// <summary> 
  /// Pochylenie (kursywa)
  ///</summary> 
  bool? Italic { get; set; }

  /// <summary> 
  /// Kursywa dla języków RTL
  ///</summary> 
  bool? ItalicBi { get; set; }

};