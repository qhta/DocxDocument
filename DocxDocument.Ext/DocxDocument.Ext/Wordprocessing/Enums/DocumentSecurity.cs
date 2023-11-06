namespace DocumentModel.Wordprocessing;

[Flags]
public enum DocumentSecurity
{
  PasswordProtected = 1,
  ReadOnlyRecommended = 2,
  ReadOnlyRestricted = 4,
  LockedForAnnotation = 8,
}
