namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the NumericValue Class.
/// </summary>
public class NumericValue: ModelElement
{
  /// <summary>
  ///   idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx { get; set; }
}