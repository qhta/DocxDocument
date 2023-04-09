namespace DocumentModel.Wordprocessing;

/// <summary>
///   Extended BaseTableProperties.
///   Contains these common properties, which are not applied to <see cref="CurrentTableProperties"/>
/// </summary>
public abstract class ExtBaseTableProperties: CurrentTableProperties
{
  /// <summary>
  ///   TableStyle.
  /// </summary>
  public String? TableStyle { get; set; }

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
  public Boolean? BiDiVisual { get; set; }

  /// <summary>
  ///   TableCaption, this property is only available in Office 2010 and later..
  /// </summary>
  public String? TableCaption { get; set; }

  /// <summary>
  ///   TableDescription, this property is only available in Office 2010 and later..
  /// </summary>
  public String? TableDescription { get; set; }
}