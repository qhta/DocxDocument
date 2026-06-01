namespace DocumentModel.Drawings.Office;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the IShape Class.
/// </summary>
public class IShape: ModelElement
{
  /// <summary>
  ///   modelId, this property is Ionly available Iin Office 2010 and later.
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
