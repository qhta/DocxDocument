namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CellType Class.
/// </summary>
public interface CellType // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public String? CellReference { get ; set; }
  
  /// <summary>
  /// Style Index
  /// </summary>
  public UInt32? StyleIndex { get ; set; }
  
  /// <summary>
  /// Cell Data Type
  /// </summary>
  public CellKind? DataType { get ; set; }
  
  /// <summary>
  /// Cell Metadata Index
  /// </summary>
  public UInt32? CellMetaIndex { get ; set; }
  
  /// <summary>
  /// Value Metadata Index
  /// </summary>
  public UInt32? ValueMetaIndex { get ; set; }
  
  /// <summary>
  /// Show Phonetic
  /// </summary>
  public Boolean? ShowPhonetic { get ; set; }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public CellFormula? CellFormula { get ; set; }
  
  /// <summary>
  /// Cell Value.
  /// </summary>
  public XstringType? CellValue { get ; set; }
  
  /// <summary>
  /// Rich Text Inline.
  /// </summary>
  public InlineString? InlineString { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
