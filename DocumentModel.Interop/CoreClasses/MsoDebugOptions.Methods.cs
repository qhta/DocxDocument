
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents debug options for Office.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions?view=office-pia"/>
public partial class MsoDebugOptions
{
  /// <summary>
  /// Adds an assert tag to ignore.
  /// </summary>
  /// <param name="bstrTagToIgnore">The `bstrTagToIgnore` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions.addignoredasserttag?view=office-pia"/>
  public void AddIgnoredAssertTag(string bstrTagToIgnore) { throw new NotImplementedException(); }
  /// <summary>
  /// Removes an ignored assert tag.
  /// </summary>
  /// <param name="bstrTagToIgnore">The `bstrTagToIgnore` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions.removeignoredasserttag?view=office-pia"/>
  public void RemoveIgnoredAssertTag(string bstrTagToIgnore) { throw new NotImplementedException(); }
}

