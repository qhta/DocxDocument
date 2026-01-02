namespace DocumentModel.Drawings.Office;

/// <summary>
///   Defines the Shape Class.
/// </summary>
public class Shape: ModelElement
{
  /// <summary>
  ///   modelId, this property is only available in Office 2010 and later.
  /// </summary>
  public string? ModelId { get; set; }
  /// <summary>
  ///   ShapeNonVisualProperties.
  /// </summary>
  public ShapeNonVisualProperties? ShapeNonVisualProperties { get; set; }
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }
  /// <summary>
  ///   ShapeStyle.
  /// </summary>
  public ShapeStyle? ShapeStyle { get; set; }
  /// <summary>
  ///   TextBody.
  /// </summary>
  public TextBody? TextBody { get; set; }
  /// <summary>
  ///   Transform2D.
  /// </summary>
  public Transform2D? Transform2D { get; set; }
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}