using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface PropertyTest: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string Name { get; }
  MsoCondition Condition { get; }
  object Value { get; }
  object SecondValue { get; }
  MsoConnector Connector { get; }
}