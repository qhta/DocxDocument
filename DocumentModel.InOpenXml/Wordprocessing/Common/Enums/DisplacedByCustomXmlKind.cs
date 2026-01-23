namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the DisplacedByCustomXmlValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DisplacedByCustomXmlKind
{
  /// <summary>
  ///   Displaced by Next Custom XML Markup Tag.
  /// </summary>
  Next,

  /// <summary>
  ///   Displaced by Previous Custom XML Markup Tag.
  /// </summary>
  Previous
}