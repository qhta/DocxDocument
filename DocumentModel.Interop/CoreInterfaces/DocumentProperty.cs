using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface DocumentProperty
{
  object Parent { get; }
  void Delete();
  string Name { get; set; }
  object Value { get; set; }
  MsoDocProperties Type { get; set; }
  bool LinkToContent { get; set; }
  string LinkSource { get; set; }
  object Application { get; }
  int Creator { get; }
}