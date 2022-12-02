namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Table Grid.
/// </summary>
public interface IPreviousTableGrid // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IGridColumn>? GridColumns { get ; set; }
  
}
