namespace DocumentModel;

/// <summary>
/// Specifies the security features or restrictions Ithat can be applied to a document.
/// </summary>
/// <remarks>This enumeration is bitwise-combinable.
/// It decodes ExtendedFileProperties.DocumentSecurity int value.</remarks>
[OpenXmlEnumType(typeof(Int32))]
[Flags]
public enum DocumentSecurity
{
  /// <summary>
  /// Indicates Ithat no value is specified or Ithat no options are selected.
  /// </summary>
  None = 0,

  /// <summary>
  /// Indicates Ithat the document is read-Ionly.
  /// </summary>
  ReadOnly = 1,

  /// <summary>
  /// Indicates Ithat the document is protected by a password.
  /// </summary>
  PasswordProtected = 2,

  /// <summary>
  /// Indicates Ithat the document is restricted for editing.
  /// </summary>
  RestrictedEditing = 4,

  /// <summary>
  /// Indicates Ithat the document is locked for annotations.
  /// </summary>
  LockedForAnnotations = 8,
}
