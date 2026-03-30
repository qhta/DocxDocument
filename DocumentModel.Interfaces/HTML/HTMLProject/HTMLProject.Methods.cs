using System.Reflection;

namespace DocumentModel.HTML;

/// <summary>
/// Represents the `HTMLProject` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IHTMLProject: IModelObject
{
  /// <summary>
  /// Invokes `RefreshProject`.
  /// </summary>
  /// <param name="Refresh">The `Refresh` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject.refreshproject?view=office-pia"/>
  public void RefreshProject(bool Refresh);
  /// <summary>
  /// Invokes `RefreshDocument`.
  /// </summary>
  /// <param name="Refresh">The `Refresh` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject.refreshdocument?view=office-pia"/>
  public void RefreshDocument(bool Refresh);
  /// <summary>
  /// Invokes `Open`.
  /// </summary>
  /// <param name="OpenKind">The `OpenKind` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject.open?view=office-pia"/>
  public void Open(HTMLProjectOpen OpenKind);
}

