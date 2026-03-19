using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ThemeFont: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string Name { get; set; }
  object Parent { get; }
}