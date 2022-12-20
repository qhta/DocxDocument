namespace DocxDocument.Model;

[Flags]
[JsonConverter(typeof(StringEnumConverter))]
public enum DocSecurity
{
    PasswordProtected = 1, // Dokument jest chroniony hasłem.
    RecommendedReadOnly = 2, // Zaleca się, aby dokument był otwierany tylko do odczytu.
    EnforcedReadOnly = 4, // Dokument wymusza, aby był otwierany tylko do odczytu.
    LockedForAnnotations = 8,  // Dokument jest zablokowany dla adnotacji.
}