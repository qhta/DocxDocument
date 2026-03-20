
namespace DocumentModel.Interop.Core;

public interface IMsoEServicesDialog
{
  public void Close(bool ApplyWebComponentChanges);
  public void AddTrustedDomain(string Domain);
  public string ApplicationName { get; }
  public object WebComponent { get; }
  public object ClipArt { get; }
}
