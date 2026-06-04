namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilevalidationmode?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoFileValidationMode")]
public enum FileValidationMode
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoFileValidationDefault")]
  Default,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoFileValidationSkip")]
  Skip
}
