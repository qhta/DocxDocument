using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `HTMLProject` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject?view=office-pia` for Office interop details.
/// </remarks>
public partial interface HTMLProject: InteropObject
{
  /// <summary>
  /// Gets the `State` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject.state?view=office-pia
  /// </remarks>
  public MsoHTMLProjectState State { get; }
  /// <summary>
  /// Gets the `HTMLProjectItems` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject.htmlprojectitems?view=office-pia
  /// </remarks>
  public HTMLProjectItems HTMLProjectItems { get; }
}
