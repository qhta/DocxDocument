namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the LigaturesValues enumeration.
/// </summary>
public enum LigaturesKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;standard&quot;.
  /// </summary>
  [EnumString("standard")]
  Standard,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;contextual&quot;.
  /// </summary>
  [EnumString("contextual")]
  Contextual,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;historical&quot;.
  /// </summary>
  [EnumString("historical")]
  Historical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;discretional&quot;.
  /// </summary>
  [EnumString("discretional")]
  Discretional,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;standardContextual&quot;.
  /// </summary>
  [EnumString("standardContextual")]
  StandardContextual,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;standardHistorical&quot;.
  /// </summary>
  [EnumString("standardHistorical")]
  StandardHistorical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;contextualHistorical&quot;.
  /// </summary>
  [EnumString("contextualHistorical")]
  ContextualHistorical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;standardDiscretional&quot;.
  /// </summary>
  [EnumString("standardDiscretional")]
  StandardDiscretional,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;contextualDiscretional&quot;.
  /// </summary>
  [EnumString("contextualDiscretional")]
  ContextualDiscretional,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;historicalDiscretional&quot;.
  /// </summary>
  [EnumString("historicalDiscretional")]
  HistoricalDiscretional,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;standardContextualHistorical&quot;.
  /// </summary>
  [EnumString("standardContextualHistorical")]
  StandardContextualHistorical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;standardContextualDiscretional&quot;.
  /// </summary>
  [EnumString("standardContextualDiscretional")]
  StandardContextualDiscretional,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;standardHistoricalDiscretional&quot;.
  /// </summary>
  [EnumString("standardHistoricalDiscretional")]
  StandardHistoricalDiscretional,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;contextualHistoricalDiscretional&quot;.
  /// </summary>
  [EnumString("contextualHistoricalDiscretional")]
  ContextualHistoricalDiscretional,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;all&quot;.
  /// </summary>
  [EnumString("all")]
  All,
  
}
