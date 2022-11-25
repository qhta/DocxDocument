namespace DocumentModel.InkML;

/// <summary>
/// Defines the Channel Class.
/// </summary>
public interface IChannel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public DocumentModel.InkML.ChannelDataTypeKind? Type { get ; set; }
  
  /// <summary>
  /// default
  /// </summary>
  public System.String? Default { get ; set; }
  
  /// <summary>
  /// min
  /// </summary>
  public System.Decimal? Min { get ; set; }
  
  /// <summary>
  /// max
  /// </summary>
  public System.Decimal? Max { get ; set; }
  
  /// <summary>
  /// orientation
  /// </summary>
  public DocumentModel.InkML.ChannelValueOrientationKind? Orientation { get ; set; }
  
  /// <summary>
  /// respectTo
  /// </summary>
  public System.String? RespectTo { get ; set; }
  
  /// <summary>
  /// units
  /// </summary>
  public System.String? Units { get ; set; }
  
}
