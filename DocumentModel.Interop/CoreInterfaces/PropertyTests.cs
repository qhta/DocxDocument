using System.Collections;

namespace DocumentModel.Interop.Core;

public interface PropertyTests: InteropCollection<PropertyTest>
{
  void Add
  (string Name, MsoCondition Condition, object Value, object SecondValue,
    MsoConnector Connector);

  void Remove(int Index);
}