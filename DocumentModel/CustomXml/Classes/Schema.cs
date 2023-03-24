namespace DocumentModel.CustomXml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Custom XML Schema Reference.
/// </summary>
public class Schema: ModelElement
{
  /// <summary>
  ///   Custom XML Schema Namespace
  /// </summary>
  public String? Uri { get; set; }

  /// <summary>
  ///   Resource File Location
  /// </summary>
  public String? ManifestLocation { get; set; }

  /// <summary>
  ///   Custom XML Schema Location
  /// </summary>
  public String? SchemaLocation { get; set; }
}