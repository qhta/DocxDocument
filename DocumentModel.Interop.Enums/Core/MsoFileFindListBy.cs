
namespace DocumentModel.Interop.Core;

/// <summary>
/// This enumeration applies to the Macintosh only and should not be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilefindlistby?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoFileFindListBy))]
public enum FileFindListBy
{
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileFindListBy.msoListbyName))]
  Name = 1,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileFindListBy.msoListbyTitle))]
  Title
}
