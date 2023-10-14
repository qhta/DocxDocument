namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Trendline Type
/// </summary>
public enum TrendlineKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;exp&quot;.
  /// </summary>
  Exponential,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;linear&quot;.
  /// </summary>
  Linear,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;log&quot;.
  /// </summary>
  Logarithmic,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;movingAvg&quot;.
  /// </summary>
  MovingAverage,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;poly&quot;.
  /// </summary>
  Polynomial,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;power&quot;.
  /// </summary>
  Power,
  
}
