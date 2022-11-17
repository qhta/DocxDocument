namespace DocumentModel.Office2010.Excel;

public enum ObjectType
{

  [XmlEnum("Button")]
  Button,

  [XmlEnum("CheckBox")]
  CheckBox,

  [XmlEnum("Drop")]
  Drop,

  [XmlEnum("GBox")]
  GroupBox,

  [XmlEnum("Label")]
  Label,

  [XmlEnum("List")]
  List,

  [XmlEnum("Radio")]
  Radio,

  [XmlEnum("Scroll")]
  Scroll,

  [XmlEnum("Spin")]
  Spin,

  [XmlEnum("EditBox")]
  EditBox,

  [XmlEnum("Dialog")]
  Dialog,
}
