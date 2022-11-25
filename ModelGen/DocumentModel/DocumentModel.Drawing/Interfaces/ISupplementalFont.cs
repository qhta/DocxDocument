namespace DocumentModel.Drawing;

/// <summary>
/// Font.
/// </summary>
public interface ISupplementalFont // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Script
  /// </summary>
  public System.String? Script { get ; set; }
  
  /// <summary>
  /// Typeface
  /// </summary>
  public System.String? Typeface { get ; set; }
  
}
