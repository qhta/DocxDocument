
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the location of the script anchor within a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoscriptlocation?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoScriptLocation))]
public enum ScriptLocation
{
  /// <summary>
  /// Script anchor is in the head of the document.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoScriptLocation.msoScriptLocationInHead))]
  Head = 1,
  /// <summary>
  /// Script anchor is in the body of the document.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoScriptLocation.msoScriptLocationInBody))]
  Body
}
