namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionciphermode?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("EncryptionCipherMode")]
public enum EncryptionCipherMode
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("cipherModeECB")]
  ECB,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("cipherModeCBC")]
  CBC
}
