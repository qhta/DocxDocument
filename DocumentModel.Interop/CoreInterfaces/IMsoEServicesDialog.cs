
namespace DocumentModel.Interop.Core;

public partial interface IMsoEServicesDialog
{
  public string ApplicationName { get; }
  public object WebComponent { get; }
  public object ClipArt { get; }
}
