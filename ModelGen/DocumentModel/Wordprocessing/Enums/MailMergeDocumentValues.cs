namespace DXW;


/// <summary>
///   Defines the MailMergeDocumentValues enumeration.
/// </summary>
public enum MailMergeDocumentValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;catalog&quot;.
  /// </summary>
  [EnumString("catalog")]
  Catalog,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;envelopes&quot;.
  /// </summary>
  [EnumString("envelopes")]
  Envelope,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mailingLabels&quot;.
  /// </summary>
  [EnumString("mailingLabels")]
  MailingLabel,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;formLetters&quot;.
  /// </summary>
  [EnumString("formLetters")]
  FormLetter,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;email&quot;.
  /// </summary>
  [EnumString("email")]
  Email,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;fax&quot;.
  /// </summary>
  [EnumString("fax")]
  Fax,
  
}
