namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the Shape Class.
/// </summary>
public partial class Shape
{
  
  /// <summary>
  ///   modelId, this property is only available in Office 2010 and later.
  /// </summary>
  public String? ModelId { get; set; }
  
  
  /// <summary>
  ///   ShapeNonVisualProperties.
  /// </summary>
  public DMDO.ShapeNonVisualProperties? ShapeNonVisualProperties { get; set; }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public DMDO.ShapeProperties? ShapeProperties { get; set; }
  
  
  /// <summary>
  ///   ShapeStyle.
  /// </summary>
  public DMDO.ShapeStyle? ShapeStyle { get; set; }
  
  
  /// <summary>
  ///   TextBody.
  /// </summary>
  public DMDO.TextBody? TextBody { get; set; }
  
  
  /// <summary>
  ///   Transform2D.
  /// </summary>
  public DMDO.Transform2D? Transform2D { get; set; }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public DMDO.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
