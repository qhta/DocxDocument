namespace DocumentModel.Presentation;

/// <summary>
/// Embedded Control.
/// </summary>
public interface IControl // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// spid
  /// </summary>
  public String? ShapeId { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// showAsIcon
  /// </summary>
  public Boolean? ShowAsIcon { get ; set; }
  
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// imgW
  /// </summary>
  public Int32? ImageWidth { get ; set; }
  
  /// <summary>
  /// imgH
  /// </summary>
  public Int32? ImageHeight { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
  /// <summary>
  /// Picture.
  /// </summary>
  public IPicture? Picture { get ; set; }
  
}
