using System.Collections;

namespace DocumentModel.Interop.Core;

public interface MsoDebugOptions_UTs: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  MsoDebugOptions_UT this[int Index] { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
  MsoDebugOptions_UTs GetUnitTestsInCollection(string bstrCollectionName);
  MsoDebugOptions_UT GetUnitTest(string bstrCollectionName, string bstrUnitTestName);
  MsoDebugOptions_UTs GetMatchingUnitTestsInCollection(string bstrCollectionName, string bstrUnitTestNameFilter);
}