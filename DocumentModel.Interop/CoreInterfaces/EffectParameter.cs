using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface EffectParameter: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string Name { get; }
  object Value { get; set; }
}