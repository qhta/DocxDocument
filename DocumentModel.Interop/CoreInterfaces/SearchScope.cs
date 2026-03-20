using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface SearchScope: InteropObject
{
  public MsoSearchIn Type { get; }
  public ScopeFolder ScopeFolder { get; }
}
