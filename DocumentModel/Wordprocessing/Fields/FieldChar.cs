namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a complex field character in the text run. A complex field character is a special character 
///   which delimits the start and end of a complex field or separates its field codes from its current field result.
///   Two complex field characters are required: a start character, which specifies the beginning of a complex field within the document content; 
///   and an end character, which specifies the end of a complex field. This syntax allows multiple fields to be embedded within each other.
///   These two items are separated by the optional separator character, which defines the end of the field codes and the beginning of the field contents. 
///   When the separator character is missing, it specifies that the field has no result.
/// </summary>
public class FieldChar: ModelElement, IRunContent
{
  /// <summary>
  ///   Field Character Type
  /// </summary>
  public FieldCharKind? FieldCharType { get; set; }

  /// <summary>
  ///   Field Should Not Be Recalculated
  /// </summary>
  public Boolean? FieldLock { get; set; }

  /// <summary>
  ///   Field Result Invalidated
  /// </summary>
  public Boolean? Dirty { get; set; }

  /// <summary>
  ///   Custom Field Data.
  /// </summary>
  public String? FieldData { get; set; }

  /// <summary>
  ///   Form Field Properties.
  /// </summary>
  public FormFieldData? FormFieldData { get; set; }

  /// <summary>
  ///   Previous Numbering Field Properties.
  /// </summary>
  public NumberingChange? NumberingChange { get; set; }
}