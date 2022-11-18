namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ObjectTypeValues enumeration.
/// </summary>
public enum ObjectType
{
  /// <summary>
  /// Button.
  /// </summary>
  [XmlEnum("Button")]
  Button,
  
  /// <summary>
  /// CheckBox.
  /// </summary>
  [XmlEnum("CheckBox")]
  CheckBox,
  
  /// <summary>
  /// Drop.
  /// </summary>
  [XmlEnum("Drop")]
  Drop,
  
  /// <summary>
  /// GBox.
  /// </summary>
  [XmlEnum("GBox")]
  GroupBox,
  
  /// <summary>
  /// Label.
  /// </summary>
  [XmlEnum("Label")]
  Label,
  
  /// <summary>
  /// List.
  /// </summary>
  [XmlEnum("List")]
  List,
  
  /// <summary>
  /// Radio.
  /// </summary>
  [XmlEnum("Radio")]
  Radio,
  
  /// <summary>
  /// Scroll.
  /// </summary>
  [XmlEnum("Scroll")]
  Scroll,
  
  /// <summary>
  /// Spin.
  /// </summary>
  [XmlEnum("Spin")]
  Spin,
  
  /// <summary>
  /// EditBox.
  /// </summary>
  [XmlEnum("EditBox")]
  EditBox,
  
  /// <summary>
  /// Dialog.
  /// </summary>
  [XmlEnum("Dialog")]
  Dialog,
  
}
