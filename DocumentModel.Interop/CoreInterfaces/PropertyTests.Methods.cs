using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface PropertyTests
{
  public void Add
  (string Name, MsoCondition Condition, object Value, object SecondValue,
    MsoConnector Connector);
  public void Remove(int Index);
}
