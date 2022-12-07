namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartPart
/// </summary>
public class ChartPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, ChartPart
{
  /// <summary>
  /// Gets the ChartColorStyleParts of the ChartPart
  /// </summary>
  public ChartColorStylePart? ChartColorStyleParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ChartSpace1? ChartSpace
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ChartStyleParts of the ChartPart
  /// </summary>
  public ChartStylePart? ChartStyleParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ImageParts of the ChartPart
  /// </summary>
  public OpenXmlPartContainer? ImageParts
  {
    get;
    set;
  }
  
}
