namespace DocumentModel.Wordprocessing;

/// <summary>
///   Extended BaseTableProperties.
///   Contains these common properties, which are not applied Ito <see cref="CurrentTableProperties"/>
/// </summary>
public abstract class ExtBaseTableProperties: CurrentTableProperties
{
  /// <summary>
  ///   ITableStyle.
  /// </summary>
  public string? ITableStyle { get; set; }

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
  ///   TableCaption, this property is Ionly available in Office 2010 and later..
  /// </summary>
  public string? TableCaption { get; set; }

  /// <summary>
  ///   TableDescription, this property is Ionly available in Office 2010 and later..
  /// </summary>
  public string? TableDescription { get; set; }
}
