namespace DocxDocument.Model;

public enum ColorType
{
  /// <summary>Not supported.</summary>
  Mixed = -2, // 0xFFFFFFFE
  /// <summary>Color is determined by values of red, green, and blue.</summary>
  RGB = 1,
  /// <summary>Color is defined by an application-specific scheme.</summary>
  Scheme = 2,
  /// <summary>Color is determined by values of cyan, magenta, yellow, and black.</summary>
  CMYK = 3,
  /// <summary>Color Management System color type.</summary>
  CMS = 4,
  /// <summary>Not supported.</summary>
  Ink = 5,
}