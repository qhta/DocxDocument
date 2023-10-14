namespace DocumentModel.Vml;


/// <summary>
///   Shape Grouping Types
/// </summary>
public enum EditAsKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;canvas&quot;.
  /// </summary>
  Canvas,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;orgchart&quot;.
  /// </summary>
  OrganizationChart,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;radial&quot;.
  /// </summary>
  Radial,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cycle&quot;.
  /// </summary>
  Cycle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;stacked&quot;.
  /// </summary>
  Stacked,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;venn&quot;.
  /// </summary>
  Venn,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bullseye&quot;.
  /// </summary>
  Bullseye,
  
}
