using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of debug unit tests.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_uts?view=office-pia
/// </remarks>
public partial interface MsoDebugOptions_UTs
{
  /// <summary>
  /// Gets unit tests in a specific collection.
  /// </summary>
  /// <param name="bstrCollectionName">The `bstrCollectionName` parameter.</param>
  /// <returns>The matching unit tests.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_uts.getunittestsincollection?view=office-pia
  /// </remarks>
  public MsoDebugOptions_UTs GetUnitTestsInCollection(string bstrCollectionName);
  /// <summary>
  /// Gets a specific unit test by collection and test name.
  /// </summary>
  /// <param name="bstrCollectionName">The `bstrCollectionName` parameter.</param>
  /// <param name="bstrUnitTestName">The `bstrUnitTestName` parameter.</param>
  /// <returns>The matching unit test.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_uts.getunittest?view=office-pia
  /// </remarks>
  public MsoDebugOptions_UT GetUnitTest(string bstrCollectionName, string bstrUnitTestName);
  /// <summary>
  /// Gets unit tests in a collection that match a name filter.
  /// </summary>
  /// <param name="bstrCollectionName">The `bstrCollectionName` parameter.</param>
  /// <param name="bstrUnitTestNameFilter">The `bstrUnitTestNameFilter` parameter.</param>
  /// <returns>The matching unit tests.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_uts.getmatchingunittestsincollection?view=office-pia
  /// </remarks>
  public MsoDebugOptions_UTs GetMatchingUnitTestsInCollection(string bstrCollectionName, string bstrUnitTestNameFilter);
}
