using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a folder-tree scope that can be searched.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchscope?view=office-pia
/// </remarks>
public partial interface SearchScope: InteropObject
{
  /// <summary>
  /// Gets the type of this search scope.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchscope.type?view=office-pia
  /// </remarks>
  public MsoSearchIn Type { get; }
  /// <summary>
  /// Gets the root folder for this search scope.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchscope.scopefolder?view=office-pia
  /// </remarks>
  public ScopeFolder ScopeFolder { get; }
}
