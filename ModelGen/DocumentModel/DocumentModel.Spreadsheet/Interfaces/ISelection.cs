namespace DocumentModel.Spreadsheet;

/// <summary>
/// Selection.
/// </summary>
public interface ISelection // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Pane
  /// </summary>
  public DocumentModel.Spreadsheet.PaneKind? Pane { get ; set; }
  
  /// <summary>
  /// Active Cell Location
  /// </summary>
  public System.String? ActiveCell { get ; set; }
  
  /// <summary>
  /// Active Cell Index
  /// </summary>
  public System.UInt32? ActiveCellId { get ; set; }
  
  /// <summary>
  /// Sequence of References
  /// </summary>
  public System.Collections.Generic.List<System.String>? SequenceOfReferences { get ; set; }
  
}
