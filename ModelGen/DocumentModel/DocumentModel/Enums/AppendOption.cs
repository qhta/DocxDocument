namespace DocumentModel;

/// <summary>
/// Options to define how an element should be appeneded.
/// </summary>
[Obsolete("This is not used and will be removed in a future version.")]
public enum AppendOption
{
  /// <summary>
  /// Append the item in list order without regard to schema.
  /// </summary>
  List,
  
  /// <summary>
  /// Append the item in accordance with what the schema defines.
  /// </summary>
  Ordered,
  
}
