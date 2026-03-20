using System.Collections;

namespace DocumentModel.Interop.Core;

public interface MsoDebugOptions_UTs: InteropCollection<MsoDebugOptions_UT>
{
  MsoDebugOptions_UTs GetUnitTestsInCollection(string bstrCollectionName);
  MsoDebugOptions_UT GetUnitTest(string bstrCollectionName, string bstrUnitTestName);
  MsoDebugOptions_UTs GetMatchingUnitTestsInCollection(string bstrCollectionName, string bstrUnitTestNameFilter);
}