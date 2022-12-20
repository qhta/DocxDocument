namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Presentation Of.
/// </summary>
public partial interface PresentationOf
{
  /// <summary>
  /// Axis
  /// </summary>
  public DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.AxisKind>? Axis { get; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.ElementKind>? PointType { get; set; }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public DocumentModel.ListOf<System.Boolean>? HideLastTrans { get; set; }
  
  /// <summary>
  /// Start
  /// </summary>
  public DocumentModel.ListOf<System.Int32>? Start { get; set; }
  
  /// <summary>
  /// Count
  /// </summary>
  public DocumentModel.ListOf<System.UInt32>? Count { get; set; }
  
  /// <summary>
  /// Step
  /// </summary>
  public DocumentModel.ListOf<System.Int32>? Step { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList { get; set; }
  
}
