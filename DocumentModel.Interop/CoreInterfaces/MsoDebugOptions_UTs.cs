using System.Collections;

namespace DocumentModel.Interop.Core;

public interface MsoDebugOptions_UTs: InteropObject, IEnumerable
{
  MsoDebugOptions_UT this[int Index] { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
  MsoDebugOptions_UTs GetUnitTestsInCollection(string bstrCollectionName);
  MsoDebugOptions_UT GetUnitTest(string bstrCollectionName, string bstrUnitTestName);
  MsoDebugOptions_UTs GetMatchingUnitTestsInCollection(string bstrCollectionName, string bstrUnitTestNameFilter);
}