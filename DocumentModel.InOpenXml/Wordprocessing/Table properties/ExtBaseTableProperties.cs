namespace DocumentModel.Wordprocessing;
/// <summary>
/// Extended base table properties class.
/// Contains additional common properties for table formatting and metadata, which are not applied to <see cref = "CurrentTableProperties"/>.
/// </summary>
public partial class ExtBaseTableProperties : CurrentTableProperties
{
  /// <summary>
  /// Table style name, specifying the style applied to the table.
  /// </summary>
  public string? TableStyle { get; set; }
  /// <summary>
  /// Table position properties, controlling the positioning of the table within the document.
  /// </summary>
  public TablePositionProperties? TablePositionProperties { get; set; }
  /// <summary>
  /// Table overlap setting, specifying how the table interacts with other tables or content.
  /// </summary>
  public TableOverlapKind? TableOverlap { get; set; }
  /// <summary>
  /// BiDi visual property, indicating whether the table uses bidirectional visual layout.
  /// </summary>
  public bool? BiDiVisual { get; set; }
  /// <summary>
  /// Table caption, providing a descriptive title for the table.
  /// </summary>
  public string? TableCaption { get; set; }
  /// <summary>
  /// Table description, providing additional metadata or explanation for the table.
  /// </summary>
  public string? TableDescription { get; set; }
}