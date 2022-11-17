namespace DocumentModel.Presentation;

public enum SplitterBarState
{

  [XmlEnum("minimized")]
  Minimized,

  [XmlEnum("restored")]
  Restored,

  [XmlEnum("maximized")]
  Maximized,
}
