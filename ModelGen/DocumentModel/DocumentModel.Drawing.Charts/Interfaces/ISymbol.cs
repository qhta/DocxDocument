namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Symbol.
/// </summary>
public interface ISymbol // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Marker Style Value
  /// </summary>
  public MarkerStyleValues? Val { get ; set; }
  
}
