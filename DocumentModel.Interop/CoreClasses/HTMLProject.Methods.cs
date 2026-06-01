using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `HTMLProject` class.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject?view=office-pia` for Office interop details.
/// </remarks>
public partial class HTMLProject
{
  /// <summary>
  /// Invokes `RefreshProject`.
  /// </summary>
  /// <param name="Refresh">The `Refresh` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject.refreshproject?view=office-pia"/>
  public void RefreshProject(bool Refresh) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `RefreshDocument`.
  /// </summary>
  /// <param name="Refresh">The `Refresh` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject.refreshdocument?view=office-pia"/>
  public void RefreshDocument(bool Refresh) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Open`.
  /// </summary>
  /// <param name="OpenKind">The `OpenKind` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject.open?view=office-pia"/>
  public void Open(HTMLProjectOpen OpenKind) { throw new NotImplementedException(); }
}

