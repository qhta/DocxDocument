namespace DocumentModel.Wordprocessing;
/// <summary>
///   Style Table Properties.
/// </summary>
public interface StyleTableProperties: BaseTableProperties
{
  /// <summary>
  ///   TableStyleRowBandSize.
  /// </summary>
  public Int32? TableStyleRowBandSize { get; set; }
  /// <summary>
  ///   TableStyleColumnBandSize.
  /// </summary>
  public Int32? TableStyleColumnBandSize { get; set; }
}