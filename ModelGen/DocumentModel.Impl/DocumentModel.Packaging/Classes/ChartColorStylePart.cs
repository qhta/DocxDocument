namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartColorStylePart
/// </summary>
public class ChartColorStylePartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, ChartColorStylePart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ColorStyle? ColorStyle
  {
    get;
    set;
  }
  
}
