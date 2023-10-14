namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Bar Grouping
/// </summary>
public enum BarGroupingKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;percentStacked&quot;.
  /// </summary>
  PercentStacked,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;clustered&quot;.
  /// </summary>
  Clustered,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;standard&quot;.
  /// </summary>
  Standard,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;stacked&quot;.
  /// </summary>
  Stacked,
  
}
