namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Shape Class.
/// </summary>
public interface Shape1
{
  /// <summary>
  /// modelId, this property is only available in Office 2010 and later.
  /// </summary>
  public String? ModelId { get ; set; }
  
  /// <summary>
  /// ShapeNonVisualProperties.
  /// </summary>
  public ShapeNonVisualProperties? ShapeNonVisualProperties { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties6? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public ShapeStyle1? ShapeStyle { get ; set; }
  
  /// <summary>
  /// TextBody.
  /// </summary>
  public TextBody3? TextBody { get ; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public Transform2D3? Transform2D { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList1? OfficeArtExtensionList { get ; set; }
  
}
