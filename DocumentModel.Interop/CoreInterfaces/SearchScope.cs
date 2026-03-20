using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface SearchScope: InteropObject
{
  public MsoSearchIn Type { get; }
  public ScopeFolder ScopeFolder { get; }
}
