namespace DocumentModel.Spreadsheet;

/// <summary>
/// Metadata Type Information.
/// </summary>
public class MetadataType: IMetadataType
{
  /// <summary>
  /// Metadata Type Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Minimum Supported Version
  /// </summary>
  public uint? MinSupportedVersion
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Ghost Row
  /// </summary>
  public bool? GhostRow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Ghost Column
  /// </summary>
  public bool? GhostColumn
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Edit
  /// </summary>
  public bool? Edit
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Cell Value Delete
  /// </summary>
  public bool? Delete
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Copy
  /// </summary>
  public bool? Copy
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Paste All
  /// </summary>
  public bool? PasteAll
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Paste Formulas
  /// </summary>
  public bool? PasteFormulas
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Paste Special Values
  /// </summary>
  public bool? PasteValues
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Paste Formats
  /// </summary>
  public bool? PasteFormats
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Paste Comments
  /// </summary>
  public bool? PasteComments
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Paste Data Validation
  /// </summary>
  public bool? PasteDataValidation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Paste Borders
  /// </summary>
  public bool? PasteBorders
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Paste Column Widths
  /// </summary>
  public bool? PasteColWidths
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Paste Number Formats
  /// </summary>
  public bool? PasteNumberFormats
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Merge
  /// </summary>
  public bool? Merge
  {
    get;
    set;
  }
  
  /// <summary>
  /// Meatadata Split First
  /// </summary>
  public bool? SplitFirst
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Split All
  /// </summary>
  public bool? SplitAll
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Insert Delete
  /// </summary>
  public bool? RowColumnShift
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Clear All
  /// </summary>
  public bool? ClearAll
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Clear Formats
  /// </summary>
  public bool? ClearFormats
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Clear Contents
  /// </summary>
  public bool? ClearContents
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Clear Comments
  /// </summary>
  public bool? ClearComments
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Formula Assignment
  /// </summary>
  public bool? Assign
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Coercion
  /// </summary>
  public bool? Coerce
  {
    get;
    set;
  }
  
  /// <summary>
  /// Adjust Metadata
  /// </summary>
  public bool? Adjust
  {
    get;
    set;
  }
  
  /// <summary>
  /// Cell Metadata
  /// </summary>
  public bool? CellMeta
  {
    get;
    set;
  }
  
}
