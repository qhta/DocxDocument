
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `MsoDebugOptions` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions?view=office-pia` for Office interop details.
/// </remarks>
public partial interface MsoDebugOptions
{
  /// <summary>
  /// Invokes `AddIgnoredAssertTag`.
  /// </summary>
  /// <param name="bstrTagToIgnore">The `bstrTagToIgnore` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions.addignoredasserttag?view=office-pia
  /// </remarks>
  public void AddIgnoredAssertTag(string bstrTagToIgnore);
  /// <summary>
  /// Invokes `RemoveIgnoredAssertTag`.
  /// </summary>
  /// <param name="bstrTagToIgnore">The `bstrTagToIgnore` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions.removeignoredasserttag?view=office-pia
  /// </remarks>
  public void RemoveIgnoredAssertTag(string bstrTagToIgnore);
}
