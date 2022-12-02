namespace DocumentModel.Drawing;

/// <summary>
/// Presentation Of.
/// </summary>
public interface IPresentationOf // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Axis
  /// </summary>
  public System.Collections.Generic.List<DocumentModel.Drawing.AxisKind>? Axis { get ; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public System.Collections.Generic.List<DocumentModel.Drawing.ElementKind>? PointType { get ; set; }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public System.Collections.Generic.List<System.Boolean>? HideLastTrans { get ; set; }
  
  /// <summary>
  /// Start
  /// </summary>
  public System.Collections.Generic.List<System.Int32>? Start { get ; set; }
  
  /// <summary>
  /// Count
  /// </summary>
  public System.Collections.Generic.List<System.UInt32>? Count { get ; set; }
  
  /// <summary>
  /// Step
  /// </summary>
  public System.Collections.Generic.List<System.Int32>? Step { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
