
namespace DocumentModel.Interop.Core;

public interface IMsoEServicesDialog
{
  void Close(bool ApplyWebComponentChanges);
  void AddTrustedDomain(string Domain);
  string ApplicationName { get; }
  object WebComponent { get; }
  object ClipArt { get; }
}