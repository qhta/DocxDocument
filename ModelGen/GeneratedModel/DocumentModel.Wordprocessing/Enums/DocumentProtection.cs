namespace DocumentModel.Wordprocessing;

public enum DocumentProtection
{

  [XmlEnum("none")]
  None,

  [XmlEnum("readOnly")]
  ReadOnly,

  [XmlEnum("comments")]
  Comments,

  [XmlEnum("trackedChanges")]
  TrackedChanges,

  [XmlEnum("forms")]
  Forms,
}
