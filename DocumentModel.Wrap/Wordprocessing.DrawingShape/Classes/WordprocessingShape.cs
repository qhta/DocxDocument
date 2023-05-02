namespace DocumentModel.Wordprocessing.DrawingShape;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the WordprocessingShape Class.
/// </summary>
public class WordprocessingShape: ModelElement
{
  /// <summary>
  ///   normalEastAsianFlow, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? NormalEastAsianFlow { get; set; }

  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }

  public NonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties { get; set; }

  public NonVisualConnectorProperties? NonVisualConnectorProperties { get; set; }

  public ShapeProperties? ShapeProperties { get; set; }

  public ShapeStyle? ShapeStyle { get; set; }

  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }

  public TextBoxInfo2? TextBoxInfo2 { get; set; }

  public LinkedTextBox? LinkedTextBox { get; set; }

  public TextBodyProperties? TextBodyProperties { get; set; }
}