
namespace DocumentModel.Interop.Core;

public interface IMsoEServicesDialog
{
  void Close(bool ApplyWebComponentChanges = false);
  void AddTrustedDomain(string Domain);
  string ApplicationName { get; }
  object Application { get; }
  object WebComponent { get; }
  object ClipArt { get; }
}