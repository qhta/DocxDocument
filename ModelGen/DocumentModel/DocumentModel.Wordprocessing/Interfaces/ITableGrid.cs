namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Grid.
/// </summary>
public interface ITableGrid // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IGridColumn>? GridColumns { get ; set; }
  
  public DocumentModel.Wordprocessing.ITableGridChange? TableGridChange { get ; set; }
  
}
