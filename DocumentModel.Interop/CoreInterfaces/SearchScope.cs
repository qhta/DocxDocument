using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface SearchScope: InteropObject
{
  MsoSearchIn Type { get; }
  ScopeFolder ScopeFolder { get; }
}