using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a top-level HTML project branch in Script Editor.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject?view=office-pia"/>
public interface IHTMLProject: IInteropObject
{
  /// <summary>
  /// Gets the `State` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject.state?view=office-pia"/>
  public HTMLProjectState State { get; }
  /// <summary>
  /// Gets the `HTMLProjectItems` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject.htmlprojectitems?view=office-pia"/>
  public IHTMLProjectItems HTMLProjectItems { get; }


  #region methods

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

  #endregion methods
}

