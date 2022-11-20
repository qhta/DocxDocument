namespace DocumentModel.InkML;

/// <summary>
/// Defines the ChannelProperty Class.
/// </summary>
public class ChannelProperty: IChannelProperty
{
  /// <summary>
  /// channel
  /// </summary>
  public string? Channel
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
  /// value
  /// </summary>
  public decimal? Value
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
