namespace DocumentModel.InkML;

/// <summary>
/// Defines the Channel Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.InkML.IMapping))]
public class Channel: IChannel
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// type
  /// </summary>
  public ChannelDataTypeValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// default
  /// </summary>
  public string? Default
  {
    get;
    set;
  }
  
  /// <summary>
  /// min
  /// </summary>
  public decimal? Min
  {
    get;
    set;
  }
  
  /// <summary>
  /// max
  /// </summary>
  public decimal? Max
  {
    get;
    set;
  }
  
  /// <summary>
  /// orientation
  /// </summary>
  public ChannelValueOrientationValues? Orientation
  {
    get;
    set;
  }
  
  /// <summary>
  /// respectTo
  /// </summary>
  public string? RespectTo
  {
    get;
    set;
  }
  
  /// <summary>
  /// units
  /// </summary>
  public string? Units
  {
    get;
    set;
  }
  
}
