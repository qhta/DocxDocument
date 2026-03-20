using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `MsoDebugOptions_UTs` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_uts?view=office-pia` for Office interop details.
/// </remarks>
public partial interface MsoDebugOptions_UTs
{
  /// <summary>
  /// Invokes `GetUnitTestsInCollection`.
  /// </summary>
  /// <param name="bstrCollectionName">The `bstrCollectionName` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_uts.getunittestsincollection?view=office-pia
  /// </remarks>
  public MsoDebugOptions_UTs GetUnitTestsInCollection(string bstrCollectionName);
  /// <summary>
  /// Invokes `GetUnitTest`.
  /// </summary>
  /// <param name="bstrCollectionName">The `bstrCollectionName` parameter.</param>
  /// <param name="bstrUnitTestName">The `bstrUnitTestName` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_uts.getunittest?view=office-pia
  /// </remarks>
  public MsoDebugOptions_UT GetUnitTest(string bstrCollectionName, string bstrUnitTestName);
  /// <summary>
  /// Invokes `GetMatchingUnitTestsInCollection`.
  /// </summary>
  /// <param name="bstrCollectionName">The `bstrCollectionName` parameter.</param>
  /// <param name="bstrUnitTestNameFilter">The `bstrUnitTestNameFilter` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_uts.getmatchingunittestsincollection?view=office-pia
  /// </remarks>
  public MsoDebugOptions_UTs GetMatchingUnitTestsInCollection(string bstrCollectionName, string bstrUnitTestNameFilter);
}
