
namespace DocumentModel.Interop.Core;

public interface IMsoCategory
{
  object Parent { get; }
  string Name { get; }
  bool IsFiltered { get; set; }
}