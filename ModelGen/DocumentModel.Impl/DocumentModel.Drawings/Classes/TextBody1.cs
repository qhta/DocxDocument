namespace DocumentModel.Drawings;

/// <summary>
/// Text Body.
/// </summary>
public class TextBody1Impl: ModelElement<DocumentFormat.OpenXml.Drawing.Diagrams.TextBody>, TextBody1
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
