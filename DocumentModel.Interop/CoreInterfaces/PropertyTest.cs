using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface PropertyTest: InteropObject
{
  public string Name { get; }
  public MsoCondition Condition { get; }
  public object Value { get; }
  public object SecondValue { get; }
  public MsoConnector Connector { get; }
}
