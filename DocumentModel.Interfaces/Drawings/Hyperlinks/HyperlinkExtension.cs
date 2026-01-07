namespace DocumentModel.Drawings;

/// <summary>
///   Represents an extension for hyperlink formatting in a drawing object, specifying additional hyperlink properties such as URI and color.
/// </summary>
public interface HyperlinkExtension: CollectionItem
{
  /// <summary>
  ///   Uniform Resource Identifier (URI) associated with the hyperlink extension.
  /// </summary>
  public string? Uri { get; set; }

  /// <summary>
  ///   Color type for the hyperlink.
  /// </summary>
  public HyperlinkColorEnum? HyperlinkColor { get; set; }
}