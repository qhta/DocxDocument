namespace DocumentModel.Drawing;

/// <summary>
/// Font.
/// </summary>
public interface ISupplementalFont // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Script
  /// </summary>
  public String? Script { get ; set; }
  
  /// <summary>
  /// Typeface
  /// </summary>
  public String? Typeface { get ; set; }
  
}
