namespace DocumentModel.Spreadsheet;

/// <summary>
/// Selection.
/// </summary>
public interface ISelection // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Pane
  /// </summary>
  public PaneKind? Pane { get ; set; }
  
  /// <summary>
  /// Active Cell Location
  /// </summary>
  public String? ActiveCell { get ; set; }
  
  /// <summary>
  /// Active Cell Index
  /// </summary>
  public UInt32? ActiveCellId { get ; set; }
  
  /// <summary>
  /// Sequence of References
  /// </summary>
  public List<String>? SequenceOfReferences { get ; set; }
  
}
