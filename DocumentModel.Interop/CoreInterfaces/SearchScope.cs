using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SearchScope` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchscope?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SearchScope: InteropObject
{
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchscope.type?view=office-pia
  /// </remarks>
  public MsoSearchIn Type { get; }
  /// <summary>
  /// Gets the `ScopeFolder` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchscope.scopefolder?view=office-pia
  /// </remarks>
  public ScopeFolder ScopeFolder { get; }
}
