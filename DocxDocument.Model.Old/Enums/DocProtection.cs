namespace DocxDocument.Model;

/// <summary>
/// Document Editing Restrictions.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DocProtection
{
  None,
  ReadOnly,
  Comments,
  TrackedChanges,
  Forms,
}