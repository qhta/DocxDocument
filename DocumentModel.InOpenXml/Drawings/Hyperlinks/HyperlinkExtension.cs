namespace DocumentModel.Drawings;

/// <summary>
///   Represents an extension for hyperlink formatting in a drawing object, specifying additional hyperlink properties such as URI and color.
/// </summary>
public interface HyperlinkExtension: IExtension
{

  /// <summary>
  ///   Color type for the hyperlink.
  /// </summary>
  public HyperlinkColorEnum? HyperlinkColor { get; set; }
}