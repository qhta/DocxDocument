
namespace DocumentModel.Interop.Core;

public interface EncryptionProvider
{
  object GetProviderDetail(EncryptionProviderDetail encprovdet);
  int NewSession(object ParentWindow);
  int Authenticate(object ParentWindow, object EncryptionData, out uint PermissionsMask);
  int CloneSession(int SessionHandle);
  void EndSession(int SessionHandle);
  int Save(int SessionHandle, object EncryptionData);
  void EncryptStream(int SessionHandle, string StreamName, object UnencryptedStream, object EncryptedStream);
  void DecryptStream(int SessionHandle, string StreamName, object EncryptedStream, object UnencryptedStream);
  void ShowSettings(int SessionHandle, object ParentWindow, bool ReadOnly, out bool Remove);
}