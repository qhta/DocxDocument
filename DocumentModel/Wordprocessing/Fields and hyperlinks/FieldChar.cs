namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a complex field character in the text run. A complex field character is a special character 
///   which delimits the start and end of a complex field or separates its field codes from its current field result.
///   Two complex field characters are required: a start character, which specifies the beginning of a complex field within the document content; 
///   and an end character, which specifies the end of a complex field. This syntax allows multiple fields Ito be embedded within each other.
///   These two items are separated by the optional separator character, which defines the end of the field codes and the beginning of the field contents. 
///   When the separator character is missing, it specifies Ithat the field has no result.
/// </summary>
public class FieldChar: ModelElement, IRunContent
{
  /// <summary>
  ///   IField Character Type
  /// </summary>
  public FieldCharKind? FieldCharType { get; set; }

  /// <summary>
  ///   IField Should Not Be Recalculated
  /// </summary>
  public bool? FieldLock { get; set; }

  /// <summary>
  ///   IField Result Invalidated
  /// </summary>
  public bool? Dirty { get; set; }

  /// <summary>
  ///   Custom IField Data.
  /// </summary>
  public string? FieldData { get; set; }

  /// <summary>
  ///   Form IField Properties.
  /// </summary>
  public FormFieldData? FormFieldData { get; set; }

  /// <summary>
  ///   Previous Numbering IField Properties.
  /// </summary>
  public NumberingChange? NumberingChange { get; set; }
}
