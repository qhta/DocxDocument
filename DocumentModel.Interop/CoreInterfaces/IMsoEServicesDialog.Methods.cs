
namespace DocumentModel.Interop.Core;

public partial interface IMsoEServicesDialog
{
  public void Close(bool ApplyWebComponentChanges);
  public void AddTrustedDomain(string Domain);
}
