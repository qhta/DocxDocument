namespace DocumentModel.Wordprocessing;
/// <summary>
///   Provides extended base table properties for WordprocessingML tables, including additional formatting and metadata not present in <see cref = "CurrentTableProperties{T}"/>.
/// </summary>
[DataContract]
[XmlRoot("ExtBaseTableProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class ExtBaseTableProperties<T> : CurrentTableProperties<T> where T : DX.OpenXmlElement
{
  /// <summary>
  ///   Name of the table style applied to this table.
  /// </summary>
  public string? TableStyle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Properties controlling the positioning of the table within the document layout.
  /// </summary>
  public TablePositionProperties? TablePositionProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Specifies how the table interacts or overlaps with other tables or document content.
  /// </summary>
  public TableOverlap? TableOverlap { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Indicates whether the table uses bidirectional (BiDi) visual layout for right-to-left scripts.
  /// </summary>
  public bool? BiDiVisual { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Caption text providing a descriptive title for the table.
  /// </summary>
  public string? TableCaption { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Additional description or metadata for the table, used for accessibility or documentation.
  /// </summary>
  public string? TableDescription { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}