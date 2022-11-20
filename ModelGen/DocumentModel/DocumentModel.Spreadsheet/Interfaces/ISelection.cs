namespace DocumentModel.Spreadsheet;

/// <summary>
/// Selection.
/// </summary>
public interface ISelection // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Pane
  /// </summary>
  public PaneValues? Pane { get ; set; }
  
  /// <summary>
  /// Active Cell Location
  /// </summary>
  public string? ActiveCell { get ; set; }
  
  /// <summary>
  /// Active Cell Index
  /// </summary>
  public uint? ActiveCellId { get ; set; }
  
  /// <summary>
  /// Sequence of References
  /// </summary>
  public List<string>? SequenceOfReferences { get ; set; }
  
}
