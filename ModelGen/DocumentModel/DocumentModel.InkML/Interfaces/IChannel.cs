namespace DocumentModel.InkML;

/// <summary>
/// Defines the Channel Class.
/// </summary>
public interface IChannel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public ChannelDataTypeValues? Type { get ; set; }
  
  /// <summary>
  /// default
  /// </summary>
  public String? Default { get ; set; }
  
  /// <summary>
  /// min
  /// </summary>
  public Decimal? Min { get ; set; }
  
  /// <summary>
  /// max
  /// </summary>
  public Decimal? Max { get ; set; }
  
  /// <summary>
  /// orientation
  /// </summary>
  public ChannelValueOrientationValues? Orientation { get ; set; }
  
  /// <summary>
  /// respectTo
  /// </summary>
  public String? RespectTo { get ; set; }
  
  /// <summary>
  /// units
  /// </summary>
  public String? Units { get ; set; }
  
}
