namespace DocumentModel.Wordprocessing;

public enum DocPart
{

  [XmlEnum("none")]
  None,

  [XmlEnum("normal")]
  Normal,

  [XmlEnum("autoExp")]
  AutoExp,

  [XmlEnum("toolbar")]
  Toolbar,

  [XmlEnum("speller")]
  Speller,

  [XmlEnum("formFld")]
  FormField,

  [XmlEnum("bbPlcHdr")]
  SdtPlaceholder,
}
