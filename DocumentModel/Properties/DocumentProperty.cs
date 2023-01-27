namespace DocumentModel.Properties;

/// <summary>
///   Document Property.
/// </summary>
[XmlContentProperty(nameof(Value))]
public partial class DocumentProperty
{
  /// <summary>
  ///   Custom File Property Name
  /// </summary>
  [XmlAttribute]
  public string? Name { get; set; }

  /// <summary>
  ///   Value of the property
  /// </summary>
  public Variant? Value { get; set; }

}