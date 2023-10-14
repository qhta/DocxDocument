namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Error Value Type
/// </summary>
public enum ErrorKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cust&quot;.
  /// </summary>
  Custom,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;fixedVal&quot;.
  /// </summary>
  FixedValue,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;percentage&quot;.
  /// </summary>
  Percentage,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;stdDev&quot;.
  /// </summary>
  StandardDeviation,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;stdErr&quot;.
  /// </summary>
  StandardError,
  
}
