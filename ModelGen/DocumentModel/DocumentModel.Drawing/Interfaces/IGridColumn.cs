namespace DocumentModel.Drawing;

/// <summary>
/// Table Grid Column.
/// </summary>
public interface IGridColumn // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Width
  /// </summary>
  public System.Int64? Width { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
