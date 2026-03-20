using System.Collections;

namespace DocumentModel.Interop.Core;

public interface MsoDebugOptions_UTs: InteropCollection<MsoDebugOptions_UT>
{
  public MsoDebugOptions_UTs GetUnitTestsInCollection(string bstrCollectionName);
  public MsoDebugOptions_UT GetUnitTest(string bstrCollectionName, string bstrUnitTestName);
  public MsoDebugOptions_UTs GetMatchingUnitTestsInCollection(string bstrCollectionName, string bstrUnitTestNameFilter);
}
