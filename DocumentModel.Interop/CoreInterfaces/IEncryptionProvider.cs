
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `EncryptionProvider` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider?view=office-pia` for Office interop details.
/// </remarks>
public interface IEncryptionProvider
{


  #region methods

/// <summary>
  /// Invokes `GetProviderDetail`.
  /// </summary>
  /// <param name="encprovdet">The `encprovdet` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider.getproviderdetail?view=office-pia"/>
  public object GetProviderDetail(EncryptionProviderDetail encprovdet);
  /// <summary>
  /// Invokes `NewSession`.
  /// </summary>
  /// <param name="parentWindow">The `ParentWindow` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider.newsession?view=office-pia"/>
  public int NewSession(object parentWindow);
  /// <summary>
  /// Invokes `Authenticate`.
  /// </summary>
  /// <param name="parentWindow">The `ParentWindow` parameter.</param>
  /// <param name="encryptionData">The `EncryptionData` parameter.</param>
  /// <param name="permissionsMask">The `PermissionsMask` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider.authenticate?view=office-pia"/>
  public int Authenticate(object parentWindow, object encryptionData, out uint permissionsMask);
  /// <summary>
  /// Invokes `CloneSession`.
  /// </summary>
  /// <param name="sessionHandle">The `SessionHandle` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider.clonesession?view=office-pia"/>
  public int CloneSession(int sessionHandle);
  /// <summary>
  /// Invokes `EndSession`.
  /// </summary>
  /// <param name="sessionHandle">The `SessionHandle` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider.endsession?view=office-pia"/>
  public void EndSession(int sessionHandle);
  /// <summary>
  /// Invokes `Save`.
  /// </summary>
  /// <param name="sessionHandle">The `SessionHandle` parameter.</param>
  /// <param name="encryptionData">The `EncryptionData` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider.save?view=office-pia"/>
  public int Save(int sessionHandle, object encryptionData);
  /// <summary>
  /// Invokes `EncryptStream`.
  /// </summary>
  /// <param name="sessionHandle">The `SessionHandle` parameter.</param>
  /// <param name="streamName">The `StreamName` parameter.</param>
  /// <param name="unencryptedStream">The `UnencryptedStream` parameter.</param>
  /// <param name="encryptedStream">The `EncryptedStream` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider.encryptstream?view=office-pia"/>
  public void EncryptStream(int sessionHandle, string streamName, object unencryptedStream, object encryptedStream);
  /// <summary>
  /// Invokes `DecryptStream`.
  /// </summary>
  /// <param name="sessionHandle">The `SessionHandle` parameter.</param>
  /// <param name="streamName">The `StreamName` parameter.</param>
  /// <param name="encryptedStream">The `EncryptedStream` parameter.</param>
  /// <param name="unencryptedStream">The `UnencryptedStream` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider.decryptstream?view=office-pia"/>
  public void DecryptStream(int sessionHandle, string streamName, object encryptedStream, object unencryptedStream);
  /// <summary>
  /// Invokes `ShowSettings`.
  /// </summary>
  /// <param name="sessionHandle">The `SessionHandle` parameter.</param>
  /// <param name="parentWindow">The `ParentWindow` parameter.</param>
  /// <param name="readOnly">The `ReadOnly` parameter.</param>
  /// <param name="remove">The `Remove` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionprovider.showsettings?view=office-pia"/>
  public void ShowSettings(int sessionHandle, object parentWindow, bool readOnly, out bool remove);

  #endregion methods
}
