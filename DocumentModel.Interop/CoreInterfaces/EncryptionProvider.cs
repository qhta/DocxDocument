
namespace DocumentModel.Interop.Core;

public interface EncryptionProvider
{
  public object GetProviderDetail(EncryptionProviderDetail encprovdet);
  public int NewSession(object ParentWindow);
  public int Authenticate(object ParentWindow, object EncryptionData, out uint PermissionsMask);
  public int CloneSession(int SessionHandle);
  public void EndSession(int SessionHandle);
  public int Save(int SessionHandle, object EncryptionData);
  public void EncryptStream(int SessionHandle, string StreamName, object UnencryptedStream, object EncryptedStream);
  public void DecryptStream(int SessionHandle, string StreamName, object EncryptedStream, object UnencryptedStream);
  public void ShowSettings(int SessionHandle, object ParentWindow, bool ReadOnly, out bool Remove);
}
