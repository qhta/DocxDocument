namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DifferentialFormatType Class.
/// </summary>
public interface IDifferentialFormatType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Font Properties.
  /// </summary>
  public IFont? Font { get ; set; }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public INumberingFormat? NumberingFormat { get ; set; }
  
  /// <summary>
  /// Fill.
  /// </summary>
  public IFill? Fill { get ; set; }
  
  /// <summary>
  /// Alignment.
  /// </summary>
  public IAlignment? Alignment { get ; set; }
  
  /// <summary>
  /// Border Properties.
  /// </summary>
  public IBorder? Border { get ; set; }
  
  /// <summary>
  /// Protection Properties.
  /// </summary>
  public IProtection? Protection { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
