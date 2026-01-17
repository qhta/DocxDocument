namespace DocumentModel.Drawings;

/// <summary>
///   Represents an extension for hyperlink formatting in a drawing object, specifying additional hyperlink properties such as UriString and color.
/// </summary>
public class HyperlinkExtension: ModelElement<DXD.HyperlinkExtension>
{

  /// <summary>
  ///   Color type for the hyperlink.
  /// </summary>
  public HyperlinkColorKind? HyperlinkColor { get; set; }
}