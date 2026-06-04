namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the type of text wrap.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextcharwrap?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoTextCharWrap")]
public enum TextCharWrap
{
  /// <summary>
  /// Specifies a mixed text wrap.
  /// </summary>
  [InteropEnumValue("msoCharWrapMixed")]
  CharWrapMixed = -2,
  /// <summary>
  /// Specifies no text wrapping.
  /// </summary>
  [InteropEnumValue("msoNoCharWrap")]
  NoCharWrap = 0,
  /// <summary>
  /// Specifies wrapping text around the standard boundry of an object.
  /// </summary>
  [InteropEnumValue("msoStandardCharWrap")]
  StandardCharWrap = 1,
  /// <summary>
  /// Specifies text wrapping that adheres to restrictions imposed by some languages such as Chinese and Japanese
  /// alphabets.
  /// </summary>
  [InteropEnumValue("msoStrictCharWrap")]
  StrictCharWrap = 2,
  /// <summary>
  /// Specifies a custom text wrap scheme.
  /// </summary>
  [InteropEnumValue("msoCustomCharWrap")]
  CustomCharWrap = 3
}
