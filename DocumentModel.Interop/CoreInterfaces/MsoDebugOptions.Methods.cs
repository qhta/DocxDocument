
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents debug options for Office.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions?view=office-pia
/// </remarks>
public partial interface MsoDebugOptions
{
  /// <summary>
  /// Adds an assert tag to ignore.
  /// </summary>
  /// <param name="bstrTagToIgnore">The `bstrTagToIgnore` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions.addignoredasserttag?view=office-pia
  /// </remarks>
  public void AddIgnoredAssertTag(string bstrTagToIgnore);
  /// <summary>
  /// Removes an ignored assert tag.
  /// </summary>
  /// <param name="bstrTagToIgnore">The `bstrTagToIgnore` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions.removeignoredasserttag?view=office-pia
  /// </remarks>
  public void RemoveIgnoredAssertTag(string bstrTagToIgnore);
}
