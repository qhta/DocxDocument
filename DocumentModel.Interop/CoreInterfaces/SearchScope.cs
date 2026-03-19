using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface SearchScope: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  MsoSearchIn Type { get; }
  ScopeFolder ScopeFolder { get; }
}