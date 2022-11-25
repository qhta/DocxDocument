namespace DocumentModel.Drawing;

/// <summary>
/// Table.
/// </summary>
public interface ITable // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Properties.
  /// </summary>
  public DocumentModel.Drawing.ITableProperties? TableProperties { get ; set; }
  
  /// <summary>
  /// Table Grid.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? TableGrid { get ; set; }
  
}
