namespace DocumentModel.Drawing;

/// <summary>
/// Table Grid Column.
/// </summary>
public interface IGridColumn // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Width
  /// </summary>
  public Int64? Width { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
