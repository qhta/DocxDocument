namespace DocumentModel.Vml;

public enum ExtensionHandlingBehavior
{

  [XmlEnum("view")]
  View,

  [XmlEnum("edit")]
  Edit,

  [XmlEnum("backwardCompatible")]
  BackwardCompatible,
}
