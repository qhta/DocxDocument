namespace DocumentModel.Office.ActiveX;

public enum Persistence
{

  [XmlEnum("persistPropertyBag")]
  PersistPropertyBag,

  [XmlEnum("persistStream")]
  PersistStream,

  [XmlEnum("persistStreamInit")]
  PersistStreamInit,

  [XmlEnum("persistStorage")]
  PersistStorage,
}
