namespace DocumentModel.Spreadsheet;

/// <summary>
/// Row.
/// </summary>
public interface IRow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Row Index
  /// </summary>
  public UInt32? RowIndex { get ; set; }
  
  /// <summary>
  /// Spans
  /// </summary>
  public List<String>? Spans { get ; set; }
  
  /// <summary>
  /// Style Index
  /// </summary>
  public UInt32? StyleIndex { get ; set; }
  
  /// <summary>
  /// Custom Format
  /// </summary>
  public Boolean? CustomFormat { get ; set; }
  
  /// <summary>
  /// Row Height
  /// </summary>
  public Double? Height { get ; set; }
  
  /// <summary>
  /// Hidden
  /// </summary>
  public Boolean? Hidden { get ; set; }
  
  /// <summary>
  /// Custom Height
  /// </summary>
  public Boolean? CustomHeight { get ; set; }
  
  /// <summary>
  /// Outline Level
  /// </summary>
  public Byte? OutlineLevel { get ; set; }
  
  /// <summary>
  /// Collapsed
  /// </summary>
  public Boolean? Collapsed { get ; set; }
  
  /// <summary>
  /// Thick Top Border
  /// </summary>
  public Boolean? ThickTop { get ; set; }
  
  /// <summary>
  /// Thick Bottom
  /// </summary>
  public Boolean? ThickBot { get ; set; }
  
  /// <summary>
  /// Show Phonetic
  /// </summary>
  public Boolean? ShowPhonetic { get ; set; }
  
  /// <summary>
  /// dyDescent, this property is only available in Office 2010 and later.
  /// </summary>
  public Double? DyDescent { get ; set; }
  
  public Collection<ICell>? Cells { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
