namespace DocumentModel;

/// <summary>
/// This class represents an item of a HeadingPairs extended document property.
/// Although in OpenXml this property is of Variant type, it must be converted to this class to enable proper serialization.
/// </summary>
public class HeadingPair
{
  /// <summary>
  /// Heading text.
  /// </summary>
  [DataMember]
  public string? Heading { get; set; }

  /// <summary>
  /// Number of this heading text.
  /// </summary>
  [DataMember]
  public int Num {get; set; }
}
