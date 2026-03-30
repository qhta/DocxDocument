using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// Represents a folder-tree scope that can be searched.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchscope?view=office-pia"/>
public partial interface ISearchScope: IModelObject
{
  /// <summary>
  /// Gets the type of this search scope.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchscope.type?view=office-pia"/>
  public SearchIn Type { get; }
  /// <summary>
  /// Gets the root folder for this search scope.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.searchscope.scopefolder?view=office-pia"/>
  public IScopeFolder ScopeFolder { get; }
}

