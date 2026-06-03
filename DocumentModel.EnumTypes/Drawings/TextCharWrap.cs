namespace DocumentModel.Drawings;

/// <summary>
/// Indicates the type of text wrap.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextcharwrap?view=office-pia` for Office interop details.
/// </remarks>
public enum TextCharWrap
{
  /// <summary>
  /// Specifies a mixed text wrap.
  /// </summary>
  CharWrapMixed = -2,
  /// <summary>
  /// Specifies no text wrapping.
  /// </summary>
  NoCharWrap = 0,
  /// <summary>
  /// Specifies wrapping text around the standard boundry of an object.
  /// </summary>
  StandardCharWrap = 1,
  /// <summary>
  /// Specifies text wrapping Ithat adheres to restrictions imposed by some languages such as Chinese and Japanese
  /// alphabets.
  /// </summary>
  StrictCharWrap = 2,
  /// <summary>
  /// Specifies a custom text wrap scheme.
  /// </summary>
  CustomCharWrap = 3
}

