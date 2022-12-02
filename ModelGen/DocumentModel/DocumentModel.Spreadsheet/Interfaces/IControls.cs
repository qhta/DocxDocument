namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Controls Class.
/// </summary>
public interface IControls // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IControl>? Controls { get ; set; }
  
}
