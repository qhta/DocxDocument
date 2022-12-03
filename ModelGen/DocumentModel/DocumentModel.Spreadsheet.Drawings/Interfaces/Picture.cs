namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Defines the Picture Class.
/// </summary>
public interface Picture // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Reference To Custom Function
  /// </summary>
  public String? Macro { get ; set; }
  
  /// <summary>
  /// Publish to Server Flag
  /// </summary>
  public Boolean? Published { get ; set; }
  
  /// <summary>
  /// Non-Visual Properties for a Picture.
  /// </summary>
  public NonVisualPictureProperties? NonVisualPictureProperties { get ; set; }
  
  /// <summary>
  /// Picture Fill.
  /// </summary>
  public BlipFill? BlipFill { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public ShapeStyle? ShapeStyle { get ; set; }
  
}
