namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PredecessorDrawingElementReference Class.
/// </summary>
public interface IPredecessorDrawingElementReference // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// pred, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? Pred { get ; set; }
  
}
