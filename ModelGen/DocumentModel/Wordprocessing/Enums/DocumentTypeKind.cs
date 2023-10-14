namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the DocumentTypeValues enumeration.
/// </summary>
public enum DocumentTypeKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;notSpecified&quot;.
  /// </summary>
  NotSpecified,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;letter&quot;.
  /// </summary>
  Letter,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;eMail&quot;.
  /// </summary>
  Email,
  
}
