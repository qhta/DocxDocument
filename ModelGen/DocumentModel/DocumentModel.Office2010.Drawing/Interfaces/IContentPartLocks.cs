namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ContentPartLocks Class.
/// </summary>
public interface IContentPartLocks // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  public System.Boolean? NoGrouping { get ; set; }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  public System.Boolean? NoSelection { get ; set; }
  
  /// <summary>
  /// Disallow Shape Rotation
  /// </summary>
  public System.Boolean? NoRotation { get ; set; }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  public System.Boolean? NoChangeAspect { get ; set; }
  
  /// <summary>
  /// Disallow Shape Movement
  /// </summary>
  public System.Boolean? NoMove { get ; set; }
  
  /// <summary>
  /// Disallow Shape Resize
  /// </summary>
  public System.Boolean? NoResize { get ; set; }
  
  /// <summary>
  /// Disallow Shape Point Editing
  /// </summary>
  public System.Boolean? NoEditPoints { get ; set; }
  
  /// <summary>
  /// Disallow Showing Adjust Handles
  /// </summary>
  public System.Boolean? NoAdjustHandles { get ; set; }
  
  /// <summary>
  /// Disallow Arrowhead Changes
  /// </summary>
  public System.Boolean? NoChangeArrowheads { get ; set; }
  
  /// <summary>
  /// Disallow Shape Type Change
  /// </summary>
  public System.Boolean? NoChangeShapeType { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
