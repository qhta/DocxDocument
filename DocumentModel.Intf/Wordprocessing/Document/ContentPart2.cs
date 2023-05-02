using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ContentPart Class.
/// </summary>
public class ContentPart2: ModelElement
{
  /// <summary>
  ///   bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get; set; }

  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? RelationshipId { get; set; }

  /// <summary>
  ///   WordNonVisualContentPartShapeProperties.
  /// </summary>
  public WordNonVisualContentPartShapeProperties? WordNonVisualContentPartShapeProperties { get; set; }

  /// <summary>
  ///   Transform2D.
  /// </summary>
  public Transform2D? Transform2D { get; set; }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}