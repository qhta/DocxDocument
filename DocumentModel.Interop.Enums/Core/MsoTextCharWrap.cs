namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the type of text wrap.
/// </summary>
public enum MsoTextCharWrap
{
  /// <summary>
  /// Indicates the type of text wrap.
  /// </summary>
  msoCharWrapMixed = -2,
  /// <summary>
  /// Specifies no text wrapping. msoStandardCharWrap1 Specifies wrapping text around the standard boundry of an
  /// object.
  /// </summary>
  msoNoCharWrap = 0,
  /// <summary>
  /// Indicates the type of text wrap.
  /// </summary>
  msoStandardCharWrap = 1,
  /// <summary>
  /// Specifies text wrapping that adheres to restrictions imposed by some languages such as Chinese and Japanese
  /// alphabets. msoCustomCharWrap3 Specifies a custom text wrap scheme.
  /// </summary>
  msoStrictCharWrap = 2,
  /// <summary>
  /// Indicates the type of text wrap.
  /// </summary>
  msoCustomCharWrap = 3
}
