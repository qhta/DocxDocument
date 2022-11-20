namespace DocumentModel.Office.ActiveX;

/// <summary>
/// Defines the PersistenceValues enumeration.
/// </summary>
public enum PersistenceValues
{
  /// <summary>
  /// persistPropertyBag.
  /// </summary>
  [XmlEnum("persistPropertyBag")]
  PersistPropertyBag,
  
  /// <summary>
  /// persistStream.
  /// </summary>
  [XmlEnum("persistStream")]
  PersistStream,
  
  /// <summary>
  /// persistStreamInit.
  /// </summary>
  [XmlEnum("persistStreamInit")]
  PersistStreamInit,
  
  /// <summary>
  /// persistStorage.
  /// </summary>
  [XmlEnum("persistStorage")]
  PersistStorage,
  
}
