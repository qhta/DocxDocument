using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface EffectParameter: InteropObject
{
  string Name { get; }
  object Value { get; set; }
}