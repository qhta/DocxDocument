using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a debug unit test.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_ut?view=office-pia"/>
public partial interface IMsoDebugOptions_UT: IInteropObject
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


  #region methods

/// <summary>
  /// Runs the unit test.
  /// </summary>
  /// <returns>The unit test run result.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_ut.run?view=office-pia"/>
  public MsoDebugOptions_UTRunResult Run();

  #endregion methods
}

