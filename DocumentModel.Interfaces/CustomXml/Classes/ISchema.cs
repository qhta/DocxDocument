namespace DocumentModel.CustomXml;
/// <summary>
///   Custom XML Schema Reference.
/// </summary>
public interface ISchema: IModelElement, ICollectionItem
{
  /// <summary>
  ///   Custom XML Schema Namespace
  /// </summary>
  public Uri? Uri { get; set; }
  /// <summary>
  ///   Resource File Location
  /// </summary>
  public string? ManifestLocation { get; set; }
  /// <summary>
  ///   Custom XML Schema Location
  /// </summary>
  public string? SchemaLocation { get; set; }
}