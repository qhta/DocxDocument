namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the TextBody Class.
/// </summary>
public interface ITextBody // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  public DocumentModel.Drawing.IBodyProperties? BodyProperties { get ; set; }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public DocumentModel.Drawing.IListStyle? ListStyle { get ; set; }
  
}
