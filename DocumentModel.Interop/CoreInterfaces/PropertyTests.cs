using System.Collections;

namespace DocumentModel.Interop.Core;

public interface PropertyTests: InteropObject, IEnumerable
{
  PropertyTest this[int Index] { get; }
  int Count { get; }

  void Add
  (string Name, MsoCondition Condition, object Value, object SecondValue,
    MsoConnector Connector);

  void Remove(int Index);
  new IEnumerator GetEnumerator();
}