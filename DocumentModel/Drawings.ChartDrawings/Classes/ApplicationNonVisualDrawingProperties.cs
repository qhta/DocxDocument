namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ApplicationNonVisualDrawingProperties Class.
/// </summary>
public class ApplicationNonVisualDrawingProperties: ModelElement
{
  /// <summary>
  ///   macro, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Macro { get; set; }

  /// <summary>
  ///   fPublished, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Published { get; set; }
}