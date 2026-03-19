using System.Collections;

namespace DocumentModel.Interop.Core;

public interface PropertyTests: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  PropertyTest this[int Index] { get; }
  int Count { get; }

  void Add
  (string Name, MsoCondition Condition, object Value, object SecondValue,
    MsoConnector Connector = MsoConnector.msoConnectorAnd);

  void Remove(int Index);
  new IEnumerator GetEnumerator();
}