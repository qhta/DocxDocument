using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a debug unit test.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_ut?view=office-pia"/>
public partial interface IMsoDebugOptions_UT: InteropObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_ut.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `CollectionName` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_ut.collectionname?view=office-pia"/>
  public string CollectionName { get; }
}

