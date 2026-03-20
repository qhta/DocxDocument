using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `HTMLProjectItem` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitem?view=office-pia` for Office interop details.
/// </remarks>
public partial interface HTMLProjectItem
{
  /// <summary>
  /// Invokes `LoadFromFile`.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitem.loadfromfile?view=office-pia
  /// </remarks>
  public void LoadFromFile(string FileName);
  /// <summary>
  /// Invokes `Open`.
  /// </summary>
  /// <param name="OpenKind">The `OpenKind` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitem.open?view=office-pia
  /// </remarks>
  public void Open(MsoHTMLProjectOpen OpenKind);
  /// <summary>
  /// Invokes `SaveCopyAs`.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitem.savecopyas?view=office-pia
  /// </remarks>
  public void SaveCopyAs(string FileName);
}
