namespace DocumentModel.Properties;

/// <summary>
///   Document Property.
/// </summary>
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
  public object? Value { get; set; }

}