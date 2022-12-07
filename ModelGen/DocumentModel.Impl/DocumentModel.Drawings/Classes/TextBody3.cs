namespace DocumentModel.Drawings;

/// <summary>
/// Shape Text Body.
/// </summary>
public class TextBody3Impl: ModelElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody>, TextBody3
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  public BodyProperties? BodyProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public ListStyle? ListStyle
  {
    get;
    set;
  }
  
}
