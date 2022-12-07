namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextBodyType Class.
/// </summary>
public class TextBodyType2Impl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextBodyType>, TextBodyType2
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  public virtual BodyProperties? BodyProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public virtual ListStyle? ListStyle
  {
    get;
    set;
  }
  
}
