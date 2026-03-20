
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SmartArt` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartart?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SmartArt
{
  /// <summary>
  /// Invokes `Reset`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartart.reset?view=office-pia
  /// </remarks>
  public void Reset();
}
