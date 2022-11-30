namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Grid Column Definitions.
/// </summary>
public interface ITableGridChange // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Previous Table Grid.
  /// </summary>
  public DocumentModel.Wordprocessing.IPreviousTableGrid? PreviousTableGrid { get ; set; }
  
}
