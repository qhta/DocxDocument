namespace DocumentModel.Spreadsheet;

/// <summary>
/// Row.
/// </summary>
public interface IRow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Row Index
  /// </summary>
  public System.UInt32? RowIndex { get ; set; }
  
  /// <summary>
  /// Spans
  /// </summary>
  public System.Collections.Generic.List<System.String>? Spans { get ; set; }
  
  /// <summary>
  /// Style Index
  /// </summary>
  public System.UInt32? StyleIndex { get ; set; }
  
  /// <summary>
  /// Custom Format
  /// </summary>
  public System.Boolean? CustomFormat { get ; set; }
  
  /// <summary>
  /// Row Height
  /// </summary>
  public System.Double? Height { get ; set; }
  
  /// <summary>
  /// Hidden
  /// </summary>
  public System.Boolean? Hidden { get ; set; }
  
  /// <summary>
  /// Custom Height
  /// </summary>
  public System.Boolean? CustomHeight { get ; set; }
  
  /// <summary>
  /// Outline Level
  /// </summary>
  public System.Byte? OutlineLevel { get ; set; }
  
  /// <summary>
  /// Collapsed
  /// </summary>
  public System.Boolean? Collapsed { get ; set; }
  
  /// <summary>
  /// Thick Top Border
  /// </summary>
  public System.Boolean? ThickTop { get ; set; }
  
  /// <summary>
  /// Thick Bottom
  /// </summary>
  public System.Boolean? ThickBot { get ; set; }
  
  /// <summary>
  /// Show Phonetic
  /// </summary>
  public System.Boolean? ShowPhonetic { get ; set; }
  
  /// <summary>
  /// dyDescent, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Double? DyDescent { get ; set; }
  
}
