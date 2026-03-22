namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the color type.
/// </summary>
public enum MsoColorType
{
  /// <summary>
  /// Specifies the color type.
  /// </summary>
  msoColorTypeMixed = -2,
  /// <summary>
  /// Color is determined by values of red, green, and blue. msoColorTypeScheme2 Color is defined by an
  /// application-specific scheme.
  /// </summary>
  msoColorTypeRGB = 1,
  /// <summary>
  /// Specifies the color type.
  /// </summary>
  msoColorTypeScheme = 2,
  /// <summary>
  /// Color is determined by values of cyan, magenta, yellow, and black.
  /// </summary>
  msoColorTypeCMYK = 3,
  /// <summary>
  /// Color Management System color type.
  /// </summary>
  msoColorTypeCMS = 4,
  /// <summary>
  /// Not supported.
  /// </summary>
  msoColorTypeInk = 5
}
