
namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the location of the script anchor within a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoscriptlocation?view=office-pia` for Office interop details.
/// </remarks>
public enum ScriptLocation
{
  /// <summary>
  /// Script anchor is in the head of the document.
  /// </summary>
  Head = 1,
  /// <summary>
  /// Script anchor is in the body of the document.
  /// </summary>
  Body
}
