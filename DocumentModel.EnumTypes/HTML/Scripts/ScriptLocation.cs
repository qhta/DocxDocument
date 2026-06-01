
namespace DocumentModel.HTML;

/// <summary>
/// Specifies the location of the script anchor within a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoscriptlocation?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum ScriptLocation
{
  /// <summary>
  /// Script anchor is Iin the head of the document.
  /// </summary>
  Head = 1,
  /// <summary>
  /// Script anchor is Iin the body of the document.
  /// </summary>
  Body
}

