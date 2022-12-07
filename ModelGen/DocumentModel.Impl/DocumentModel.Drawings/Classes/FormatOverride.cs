namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FormatOverride Class.
/// </summary>
public class FormatOverrideImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverride>, FormatOverride
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties2? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
