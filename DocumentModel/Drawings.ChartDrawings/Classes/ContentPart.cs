namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ContentPart Class.
/// </summary>
public class ContentPart: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? RelationshipId { get; set; }

  /// <summary>
  ///   bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get; set; }

  /// <summary>
  ///   NonVisualContentPartProperties.
  /// </summary>
  public NonVisualContentPartProperties? NonVisualContentPartProperties { get; set; }

  /// <summary>
  ///   ApplicationNonVisualDrawingProperties.
  /// </summary>
  public ApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get; set; }

  /// <summary>
  ///   Transform2D.
  /// </summary>
  public Transform2D? Transform2D { get; set; }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}