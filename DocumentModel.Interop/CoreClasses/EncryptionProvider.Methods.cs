
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `EncryptionProvider` class.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider?view=office-pia` for Office interop details.
/// </remarks>
public partial class EncryptionProvider
{
  /// <summary>
  /// Invokes `GetProviderDetail`.
  /// </summary>
  /// <param name="encprovdet">The `encprovdet` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider.getproviderdetail?view=office-pia"/>
  public object GetProviderDetail(EncryptionProviderDetail encprovdet) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `NewSession`.
  /// </summary>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider.newsession?view=office-pia"/>
  public int NewSession(object ParentWindow) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Authenticate`.
  /// </summary>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="EncryptionData">The `EncryptionData` parameter.</param>
  /// <param name="PermissionsMask">The `PermissionsMask` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider.authenticate?view=office-pia"/>
  public int Authenticate(object ParentWindow, object EncryptionData, out uint PermissionsMask) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `CloneSession`.
  /// </summary>
  /// <param name="SessionHandle">The `SessionHandle` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider.clonesession?view=office-pia"/>
  public int CloneSession(int SessionHandle) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `EndSession`.
  /// </summary>
  /// <param name="SessionHandle">The `SessionHandle` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider.endsession?view=office-pia"/>
  public void EndSession(int SessionHandle) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Save`.
  /// </summary>
  /// <param name="SessionHandle">The `SessionHandle` parameter.</param>
  /// <param name="EncryptionData">The `EncryptionData` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider.save?view=office-pia"/>
  public int Save(int SessionHandle, object EncryptionData) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `EncryptStream`.
  /// </summary>
  /// <param name="SessionHandle">The `SessionHandle` parameter.</param>
  /// <param name="StreamName">The `StreamName` parameter.</param>
  /// <param name="UnencryptedStream">The `UnencryptedStream` parameter.</param>
  /// <param name="EncryptedStream">The `EncryptedStream` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider.encryptstream?view=office-pia"/>
  public void EncryptStream(int SessionHandle, string StreamName, object UnencryptedStream, object EncryptedStream) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `DecryptStream`.
  /// </summary>
  /// <param name="SessionHandle">The `SessionHandle` parameter.</param>
  /// <param name="StreamName">The `StreamName` parameter.</param>
  /// <param name="EncryptedStream">The `EncryptedStream` parameter.</param>
  /// <param name="UnencryptedStream">The `UnencryptedStream` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider.decryptstream?view=office-pia"/>
  public void DecryptStream(int SessionHandle, string StreamName, object EncryptedStream, object UnencryptedStream) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ShowSettings`.
  /// </summary>
  /// <param name="SessionHandle">The `SessionHandle` parameter.</param>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="ReadOnly">The `ReadOnly` parameter.</param>
  /// <param name="Remove">The `Remove` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider.showsettings?view=office-pia"/>
  public void ShowSettings(int SessionHandle, object ParentWindow, bool ReadOnly, out bool Remove) { throw new NotImplementedException(); }
}

