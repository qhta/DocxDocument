namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Error Bar Type
/// </summary>
public enum ErrorBarKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;both&quot;.
  /// </summary>
  Both,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;minus&quot;.
  /// </summary>
  Minus,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;plus&quot;.
  /// </summary>
  Plus,
  
}
