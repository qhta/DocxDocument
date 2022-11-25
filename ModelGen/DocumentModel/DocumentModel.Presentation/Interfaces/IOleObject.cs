namespace DocumentModel.Presentation;

/// <summary>
/// Global Element for OLE Objects and Controls.
/// </summary>
public interface IOleObject // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// spid
  /// </summary>
  public System.String? ShapeId { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// showAsIcon
  /// </summary>
  public System.Boolean? ShowAsIcon { get ; set; }
  
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// imgW
  /// </summary>
  public System.Int32? ImageWidth { get ; set; }
  
  /// <summary>
  /// imgH
  /// </summary>
  public System.Int32? ImageHeight { get ; set; }
  
  /// <summary>
  /// progId
  /// </summary>
  public System.String? ProgId { get ; set; }
  
}
