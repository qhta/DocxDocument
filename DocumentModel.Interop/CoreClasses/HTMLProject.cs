using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a top-level HTML project branch in Script Editor.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject?view=office-pia"/>
public partial class HTMLProject: InteropObject
{
  /// <summary>
  /// Gets the `State` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject.state?view=office-pia"/>
  public HTMLProjectState State { get; }
  /// <summary>
  /// Gets the `HTMLProjectItems` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject.htmlprojectitems?view=office-pia"/>
  public HTMLProjectItems HTMLProjectItems { get; }


  #region methods

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

  #endregion methods
}

