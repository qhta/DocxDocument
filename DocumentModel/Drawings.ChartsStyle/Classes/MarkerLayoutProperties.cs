namespace DocumentModel.Drawings.ChartsStyle;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the MarkerLayoutProperties Class.
/// </summary>
public class MarkerLayoutProperties: ModelElement
{
  /// <summary>
  ///   symbol, this property is only available in Office 2013 and later.
  /// </summary>
  public MarkerStyle? Symbol { get; set; }

  /// <summary>
  ///   size, this property is only available in Office 2013 and later.
  /// </summary>
  public Byte? Size { get; set; }
}