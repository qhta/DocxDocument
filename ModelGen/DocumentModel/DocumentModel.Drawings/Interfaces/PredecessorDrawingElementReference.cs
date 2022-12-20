namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PredecessorDrawingElementReference Class.
/// </summary>
public partial interface PredecessorDrawingElementReference
{
  /// <summary>
  /// pred, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Pred { get; set; }
  
}
