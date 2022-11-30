namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CellType Class.
/// </summary>
public interface ICellType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public System.String? CellReference { get ; set; }
  
  /// <summary>
  /// Style Index
  /// </summary>
  public System.UInt32? StyleIndex { get ; set; }
  
  /// <summary>
  /// Cell Data Type
  /// </summary>
  public DocumentModel.Spreadsheet.CellKind? DataType { get ; set; }
  
  /// <summary>
  /// Cell Metadata Index
  /// </summary>
  public System.UInt32? CellMetaIndex { get ; set; }
  
  /// <summary>
  /// Value Metadata Index
  /// </summary>
  public System.UInt32? ValueMetaIndex { get ; set; }
  
  /// <summary>
  /// Show Phonetic
  /// </summary>
  public System.Boolean? ShowPhonetic { get ; set; }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.Spreadsheet.ICellFormula? CellFormula { get ; set; }
  
  /// <summary>
  /// Cell Value.
  /// </summary>
  public DocumentModel.Spreadsheet.IXstringType? CellValue { get ; set; }
  
  /// <summary>
  /// Rich Text Inline.
  /// </summary>
  public DocumentModel.Spreadsheet.IInlineString? InlineString { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
