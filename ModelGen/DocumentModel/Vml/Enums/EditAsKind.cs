namespace DocumentModel.Vml;


/// <summary>
///   Shape Grouping Types
/// </summary>
public enum EditAsKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;canvas&quot;.
  /// </summary>
  [EnumString("canvas")]
  Canvas,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;orgchart&quot;.
  /// </summary>
  [EnumString("orgchart")]
  OrganizationChart,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;radial&quot;.
  /// </summary>
  [EnumString("radial")]
  Radial,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cycle&quot;.
  /// </summary>
  [EnumString("cycle")]
  Cycle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;stacked&quot;.
  /// </summary>
  [EnumString("stacked")]
  Stacked,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;venn&quot;.
  /// </summary>
  [EnumString("venn")]
  Venn,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bullseye&quot;.
  /// </summary>
  [EnumString("bullseye")]
  Bullseye,
  
}
