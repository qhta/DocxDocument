using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface MsoDebugOptions_UTs
{
  public MsoDebugOptions_UTs GetUnitTestsInCollection(string bstrCollectionName);
  public MsoDebugOptions_UT GetUnitTest(string bstrCollectionName, string bstrUnitTestName);
  public MsoDebugOptions_UTs GetMatchingUnitTestsInCollection(string bstrCollectionName, string bstrUnitTestNameFilter);
}
