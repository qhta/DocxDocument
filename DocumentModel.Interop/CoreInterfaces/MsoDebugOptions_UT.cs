using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a debug unit test.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_ut?view=office-pia
/// </remarks>
public partial interface MsoDebugOptions_UT: InteropObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_ut.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `CollectionName` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_ut.collectionname?view=office-pia
  /// </remarks>
  public string CollectionName { get; }
}
