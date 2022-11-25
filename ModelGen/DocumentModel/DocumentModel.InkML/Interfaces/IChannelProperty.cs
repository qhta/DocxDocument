namespace DocumentModel.InkML;

/// <summary>
/// Defines the ChannelProperty Class.
/// </summary>
public interface IChannelProperty // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// channel
  /// </summary>
  public System.String? Channel { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// value
  /// </summary>
  public System.Decimal? Value { get ; set; }
  
  /// <summary>
  /// units
  /// </summary>
  public System.String? Units { get ; set; }
  
}
