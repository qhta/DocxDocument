
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TextFrame2` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2?view=office-pia` for Office interop details.
/// </remarks>
public partial interface TextFrame2
{
  /// <summary>
  /// Invokes `DeleteText`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.deletetext?view=office-pia
  /// </remarks>
  public void DeleteText();
}
