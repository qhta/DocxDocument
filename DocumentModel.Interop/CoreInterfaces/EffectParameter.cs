using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface EffectParameter: InteropObject
{
  public string Name { get; }
  public object Value { get; set; }
}
