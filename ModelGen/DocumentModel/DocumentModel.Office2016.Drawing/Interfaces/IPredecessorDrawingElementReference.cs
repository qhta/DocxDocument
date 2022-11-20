namespace DocumentModel.Office2016.Drawing;

/// <summary>
/// Defines the PredecessorDrawingElementReference Class.
/// </summary>
public interface IPredecessorDrawingElementReference // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// pred, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Pred { get ; set; }
  
}
