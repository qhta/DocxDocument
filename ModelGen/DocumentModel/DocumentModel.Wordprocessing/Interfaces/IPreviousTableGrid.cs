namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Table Grid.
/// </summary>
public interface IPreviousTableGrid // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IGridColumn>? GridColumns { get ; set; }
  
}
