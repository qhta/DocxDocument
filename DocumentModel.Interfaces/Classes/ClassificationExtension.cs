namespace DocumentModel;

/// <summary>
///   Defines the ClassificationExtension Class.
/// </summary>
public interface ClassificationExtension: IModelElement
{
  /// <summary>
  ///   uri, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Uri { get; set; }
}