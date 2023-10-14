namespace DocumentModel.Vml;


/// <summary>
///   Gradient Fill Computation Type
/// </summary>
public enum FillMethodKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;linear&quot;.
  /// </summary>
  Linear,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sigma&quot;.
  /// </summary>
  Sigma,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;any&quot;.
  /// </summary>
  Any,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;linear sigma&quot;.
  /// </summary>
  Linearsigma,
  
}
