namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a document variable with a name and a string value in a WordprocessingML document.
/// This interface extends <see cref = "CollectionItem"/> and provides properties for the variable name and value, enabling advanced storage and retrieval of custom metadata or automation variables within the document.
/// </summary>
public partial class Variable : ModelElement<DXW.DocumentVariable>
{
  /// <summary>
  /// Name of the document variable, specifying the unique identifier for the variable.
  /// </summary>
  [XmlAttribute]
  public string? Name { get; set; }

  /// <summary>
  /// Value of the document variable, specified as a string.
  /// </summary>
  [XmlAttribute]
  public string? Val { get; set; }
}