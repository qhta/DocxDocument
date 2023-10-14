namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MailMergeDocumentValues enumeration.
/// </summary>
public enum MailMergeDocumentKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;catalog&quot;.
  /// </summary>
  Catalog,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;envelopes&quot;.
  /// </summary>
  Envelope,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mailingLabels&quot;.
  /// </summary>
  MailingLabel,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;formLetters&quot;.
  /// </summary>
  FormLetter,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;email&quot;.
  /// </summary>
  Email,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;fax&quot;.
  /// </summary>
  Fax,
  
}
