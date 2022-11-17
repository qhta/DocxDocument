namespace DocumentModel.Wordprocessing;

public enum FrameLayout
{

  [XmlEnum("rows")]
  Rows,

  [XmlEnum("cols")]
  Columns,

  [XmlEnum("none")]
  None,
}
