namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextBodyType Class.
/// </summary>
public class TextBodyType2Impl: ModelElementImpl, TextBodyType2
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextBodyType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextBodyType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
