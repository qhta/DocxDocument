namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Shape Text Body.
/// </summary>
public interface ITextBody // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  public IBodyProperties? BodyProperties { get ; set; }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public IListStyle? ListStyle { get ; set; }
  
}
