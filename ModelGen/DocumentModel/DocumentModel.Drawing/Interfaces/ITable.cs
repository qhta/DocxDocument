namespace DocumentModel.Drawing;

/// <summary>
/// Table.
/// </summary>
public interface ITable // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Properties.
  /// </summary>
  public ITableProperties? TableProperties { get ; set; }
  
  /// <summary>
  /// Table Grid.
  /// </summary>
  public ITableGrid? TableGrid { get ; set; }
  
}
