namespace DocumentModel.Wordprocessing;

/// <summary>
/// Encoded int field of DocumentSecurity in ExtendedFileProperties
/// </summary>
[Flags]
public enum DocumentSecurity
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  PasswordProtected = 1,
  ReadOnlyRecommended = 2,
  ReadOnlyRestricted = 4,
  LockedForAnnotation = 8,
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
