
namespace DocumentModel.Interop.Core;

public partial interface IMsoCategory
{
  public string Name { get; }
  public bool IsFiltered { get; set; }
}
