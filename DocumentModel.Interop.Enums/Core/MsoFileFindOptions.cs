
namespace DocumentModel.Interop.Core;

/// <summary>
/// This enumeration applies to the Macintosh only and should not be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilefindoptions?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoFileFindOptions))]
public enum FileFindOptions
{
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileFindOptions.msoOptionsNew))]
  New = 1,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileFindOptions.msoOptionsAdd))]
  Add,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileFindOptions.msoOptionsWithin))]
  Within
}
