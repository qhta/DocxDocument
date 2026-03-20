using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `HTMLProject` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject?view=office-pia` for Office interop details.
/// </remarks>
public partial interface HTMLProject
{
  /// <summary>
  /// Invokes `RefreshProject`.
  /// </summary>
  /// <param name="Refresh">The `Refresh` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject.refreshproject?view=office-pia
  /// </remarks>
  public void RefreshProject(bool Refresh);
  /// <summary>
  /// Invokes `RefreshDocument`.
  /// </summary>
  /// <param name="Refresh">The `Refresh` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject.refreshdocument?view=office-pia
  /// </remarks>
  public void RefreshDocument(bool Refresh);
  /// <summary>
  /// Invokes `Open`.
  /// </summary>
  /// <param name="OpenKind">The `OpenKind` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject.open?view=office-pia
  /// </remarks>
  public void Open(MsoHTMLProjectOpen OpenKind);
}
