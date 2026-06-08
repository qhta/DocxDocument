namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionciphermode?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.EncryptionCipherMode")]
public enum EncryptionCipherMode
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("cipherModeECB")]
  ECB,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("cipherModeCBC")]
  CBC
}
