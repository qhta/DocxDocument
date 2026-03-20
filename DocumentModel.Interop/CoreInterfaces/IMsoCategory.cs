
namespace DocumentModel.Interop.Core;

public interface IMsoCategory
{
  string Name { get; }
  bool IsFiltered { get; set; }
}