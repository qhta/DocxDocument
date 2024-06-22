namespace ModelDoc;

/// <summary>
/// Specifies how the content of an element is processed by the Xml processor.
/// </summary>
public enum ContentProcessing: byte
{
  /// <summary>
  /// Document items are not validated.
  /// </summary>
  None,
  /// <summary>
  /// Document items must consist of well-formed XML and are not validated by the schema.
  /// </summary>
  Skip,

  /// <summary>
  /// If the associated schema is found, the document items will be validated. No errors will be thrown otherwise.
  /// </summary>
  Lax,

  /// <summary>
  /// The schema processor must find a schema associated with the indicated namespace to validate the document items.
  /// </summary>
  Strict
}
