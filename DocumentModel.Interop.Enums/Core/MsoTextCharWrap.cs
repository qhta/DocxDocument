namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the type of text wrap.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextcharwrap?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoTextCharWrap))]
public enum TextCharWrap
{
  /// <summary>
  /// Specifies a mixed text wrap.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextCharWrap.msoCharWrapMixed))]
  CharWrapMixed = -2,
  /// <summary>
  /// Specifies no text wrapping.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextCharWrap.msoNoCharWrap))]
  NoCharWrap = 0,
  /// <summary>
  /// Specifies wrapping text around the standard boundry of an object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextCharWrap.msoStandardCharWrap))]
  StandardCharWrap = 1,
  /// <summary>
  /// Specifies text wrapping that adheres to restrictions imposed by some languages such as Chinese and Japanese
  /// alphabets.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextCharWrap.msoStrictCharWrap))]
  StrictCharWrap = 2,
  /// <summary>
  /// Specifies a custom text wrap scheme.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextCharWrap.msoCustomCharWrap))]
  CustomCharWrap = 3
}
