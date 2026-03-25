
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents debug options for Office.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions?view=office-pia"/>
public partial interface MsoDebugOptions: InteropObject
{
  /// <summary>
  /// Adds an assert tag to ignore.
  /// </summary>
  /// <param name="bstrTagToIgnore">The `bstrTagToIgnore` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions.addignoredasserttag?view=office-pia"/>
  public void AddIgnoredAssertTag(string bstrTagToIgnore);
  /// <summary>
  /// Removes an ignored assert tag.
  /// </summary>
  /// <param name="bstrTagToIgnore">The `bstrTagToIgnore` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions.removeignoredasserttag?view=office-pia"/>
  public void RemoveIgnoredAssertTag(string bstrTagToIgnore);
}

