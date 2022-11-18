namespace DocumentModel.InkML;

/// <summary>
/// Defines the Channel Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.InkML.IMapping))]
public interface IChannel // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public ChannelDataType? Type { get ; set; }
  
  /// <summary>
  /// default
  /// </summary>
  public string? Default { get ; set; }
  
  /// <summary>
  /// min
  /// </summary>
  public decimal? Min { get ; set; }
  
  /// <summary>
  /// max
  /// </summary>
  public decimal? Max { get ; set; }
  
  /// <summary>
  /// orientation
  /// </summary>
  public ChannelValueOrientation? Orientation { get ; set; }
  
  /// <summary>
  /// respectTo
  /// </summary>
  public string? RespectTo { get ; set; }
  
  /// <summary>
  /// units
  /// </summary>
  public string? Units { get ; set; }
  
}
