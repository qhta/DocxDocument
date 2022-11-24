namespace DocumentModel.InkML;

/// <summary>
/// Defines the ChannelProperty Class.
/// </summary>
public interface IChannelProperty // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// channel
  /// </summary>
  public String? Channel { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// value
  /// </summary>
  public Decimal? Value { get ; set; }
  
  /// <summary>
  /// units
  /// </summary>
  public String? Units { get ; set; }
  
}
