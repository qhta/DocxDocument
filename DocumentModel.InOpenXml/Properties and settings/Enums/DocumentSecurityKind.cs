namespace DocumentModel;

/// <summary>
/// Specifies the security features or restrictions that can be applied to a document.
/// </summary>
/// <remarks>This enumeration is bitwise-combinable.
/// It decodes ExtendedFileProperties.DocumentSecurity int value.</remarks>
[OpenXmlType(typeof(DXEP.DocumentSecurity))]
[Flags]
public enum DocumentSecurityKind
{
  /// <summary>
  /// Indicates that no value is specified or that no options are selected.
  /// </summary>
  None = 0,

  /// <summary>
  /// Indicates that the document is read-only.
  /// </summary>
  ReadOnly = 1,

  /// <summary>
  /// Indicates that the document is protected by a password.
  /// </summary>
  PasswordProtected = 2,

  /// <summary>
  /// Indicates that the document is restricted for editing.
  /// </summary>
  RestrictedEditing = 4,

  /// <summary>
  /// Indicates that the document is locked for annotations.
  /// </summary>
  LockedForAnnotations = 8,
}