using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface DocumentProperty
{
  void Delete();
  string Name { get; set; }
  object Value { get; set; }
  MsoDocProperties Type { get; set; }
  bool LinkToContent { get; set; }
  string LinkSource { get; set; }
}