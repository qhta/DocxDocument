namespace DocumentModel.Wordprocessing;
/// <summary>
///   Extended BaseTableProperties.
///   Contains these common properties, which are not applied to <see cref="CurrentTableProperties"/>
/// </summary>
public interface ExtBaseTableProperties: CurrentTableProperties
{
  /// <summary>
  ///   TableStyle.
  /// </summary>
  public string? TableStyle { get; set; }
  /// <summary>
  ///   TablePositionProperties.
  /// </summary>
  public TablePositionProperties? TablePositionProperties { get; set; }
  /// <summary>
  ///   TableOverlap.
  /// </summary>
  public TableOverlapKind? TableOverlap { get; set; }
  /// <summary>
  ///   BiDiVisual.
  /// </summary>
  public bool? BiDiVisual { get; set; }
  /// <summary>
  ///   TableCaption.
  /// </summary>
  public string? TableCaption { get; set; }
  /// <summary>
  ///   TableDescription.
  /// </summary>
  public string? TableDescription { get; set; }
}