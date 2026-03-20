using System.Collections;

namespace DocumentModel.Interop.Core;

public interface PropertyTests: InteropCollection<PropertyTest>
{
  public void Add
  (string Name, MsoCondition Condition, object Value, object SecondValue,
    MsoConnector Connector);

  public void Remove(int Index);
}
