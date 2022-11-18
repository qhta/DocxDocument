namespace DocumentModel.Vml.Spreadsheet;

/// <summary>
/// Object Type
/// </summary>
public enum Object
{
  /// <summary>
  /// Pushbutton.
  /// </summary>
  [XmlEnum("Button")]
  Button,
  
  /// <summary>
  /// Checkbox.
  /// </summary>
  [XmlEnum("Checkbox")]
  Checkbox,
  
  /// <summary>
  /// Dialog.
  /// </summary>
  [XmlEnum("Dialog")]
  Dialog,
  
  /// <summary>
  /// Dropdown Box.
  /// </summary>
  [XmlEnum("Drop")]
  Drop,
  
  /// <summary>
  /// Editable Text Field.
  /// </summary>
  [XmlEnum("Edit")]
  Edit,
  
  /// <summary>
  /// Group Box.
  /// </summary>
  [XmlEnum("GBox")]
  GroupBox,
  
  /// <summary>
  /// Label.
  /// </summary>
  [XmlEnum("Label")]
  Label,
  
  /// <summary>
  /// Auditing Line.
  /// </summary>
  [XmlEnum("LineA")]
  AuditingLine,
  
  /// <summary>
  /// List Box.
  /// </summary>
  [XmlEnum("List")]
  List,
  
  /// <summary>
  /// Movie.
  /// </summary>
  [XmlEnum("Movie")]
  Movie,
  
  /// <summary>
  /// Comment.
  /// </summary>
  [XmlEnum("Note")]
  Note,
  
  /// <summary>
  /// Image.
  /// </summary>
  [XmlEnum("Pict")]
  Picture,
  
  /// <summary>
  /// Radio Button.
  /// </summary>
  [XmlEnum("Radio")]
  Radio,
  
  /// <summary>
  /// Auditing Rectangle.
  /// </summary>
  [XmlEnum("RectA")]
  AuditingRectangle,
  
  /// <summary>
  /// Scroll Bar.
  /// </summary>
  [XmlEnum("Scroll")]
  Scroll,
  
  /// <summary>
  /// Spin Button.
  /// </summary>
  [XmlEnum("Spin")]
  Spin,
  
  /// <summary>
  /// Plain Shape.
  /// </summary>
  [XmlEnum("Shape")]
  Shape,
  
  /// <summary>
  /// Group.
  /// </summary>
  [XmlEnum("Group")]
  Group,
  
  /// <summary>
  /// Plain Rectangle.
  /// </summary>
  [XmlEnum("Rect")]
  Rectangle,
  
}
