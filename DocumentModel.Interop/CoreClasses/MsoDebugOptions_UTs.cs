using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of debug unit tests.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_uts?view=office-pia"/>
public partial class MsoDebugOptions_UTs: InteropCollection<MsoDebugOptions_UT>
{


  #region methods

/// <summary>
  /// Gets unit tests in a specific collection.
  /// </summary>
  /// <param name="bstrCollectionName">The `bstrCollectionName` parameter.</param>
  /// <returns>The matching unit tests.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_uts.getunittestsincollection?view=office-pia"/>
  public MsoDebugOptions_UTs GetUnitTestsInCollection(string bstrCollectionName) { throw new NotImplementedException(); }
  /// <summary>
  /// Gets a specific unit test by collection and test name.
  /// </summary>
  /// <param name="bstrCollectionName">The `bstrCollectionName` parameter.</param>
  /// <param name="bstrUnitTestName">The `bstrUnitTestName` parameter.</param>
  /// <returns>The matching unit test.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_uts.getunittest?view=office-pia"/>
  public MsoDebugOptions_UT GetUnitTest(string bstrCollectionName, string bstrUnitTestName) { throw new NotImplementedException(); }
  /// <summary>
  /// Gets unit tests in a collection that match a name filter.
  /// </summary>
  /// <param name="bstrCollectionName">The `bstrCollectionName` parameter.</param>
  /// <param name="bstrUnitTestNameFilter">The `bstrUnitTestNameFilter` parameter.</param>
  /// <returns>The matching unit tests.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_uts.getmatchingunittestsincollection?view=office-pia"/>
  public MsoDebugOptions_UTs GetMatchingUnitTestsInCollection(string bstrCollectionName, string bstrUnitTestNameFilter) { throw new NotImplementedException(); }

  #endregion methods
}

