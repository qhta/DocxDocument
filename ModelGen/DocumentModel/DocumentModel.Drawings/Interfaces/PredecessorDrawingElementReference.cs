namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PredecessorDrawingElementReference Class.
/// </summary>
public interface PredecessorDrawingElementReference // : System.Boolean
{
  /// <summary>
  /// pred, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Pred { get ; set; }
  
}
