namespace DocumentModel.Spreadsheet;

/// <summary>
/// Revision Format.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDifferentialFormat))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
public interface IRevisionFormat // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Sheet Id
  /// </summary>
  public uint? SheetId { get ; set; }
  
  /// <summary>
  /// Row or Column Formatting Change
  /// </summary>
  public bool? RowOrColumnAffected { get ; set; }
  
  /// <summary>
  /// Style
  /// </summary>
  public bool? StyleAffected { get ; set; }
  
  /// <summary>
  /// Sequence Of References
  /// </summary>
  public List<string>? SequenceOfReferences { get ; set; }
  
  /// <summary>
  /// Start index
  /// </summary>
  public uint? Start { get ; set; }
  
  /// <summary>
  /// Length
  /// </summary>
  public uint? Length { get ; set; }
  
  /// <summary>
  /// Formatting.
  /// </summary>
  public IDifferentialFormat? DifferentialFormat { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
