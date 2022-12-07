namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextBody Class.
/// </summary>
public class TextBody2Impl: ModelElement<DocumentFormat.OpenXml.Office.Drawing.TextBody>, TextBody2
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
