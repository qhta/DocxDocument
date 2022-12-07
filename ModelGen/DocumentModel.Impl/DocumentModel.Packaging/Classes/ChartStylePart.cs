namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartStylePart
/// </summary>
public class ChartStylePartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, ChartStylePart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ChartStyle? ChartStyle
  {
    get;
    set;
  }
  
}
