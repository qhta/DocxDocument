namespace DocumentModel.Drawings.Pictures;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Picture.
/// </summary>
public class Picture: ModelElement
{
  /// <summary>
  ///   Non-Visual Picture Properties.
  /// </summary>
  public NonVisualPictureProperties? NonVisualPictureProperties { get; set; }

  /// <summary>
  ///   Picture Fill.
  /// </summary>
  public BlipFill? BlipFill { get; set; }

  /// <summary>
  ///   Shape Properties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   ShapeStyle, this property is only available in Office 2010 and later..
  /// </summary>
  public ShapeStyle? ShapeStyle { get; set; }

  /// <summary>
  ///   OfficeArtExtensionList, this property is only available in Office 2010 and later..
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}