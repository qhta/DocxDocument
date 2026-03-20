using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface PropertyTest: InteropObject
{
  string Name { get; }
  MsoCondition Condition { get; }
  object Value { get; }
  object SecondValue { get; }
  MsoConnector Connector { get; }
}