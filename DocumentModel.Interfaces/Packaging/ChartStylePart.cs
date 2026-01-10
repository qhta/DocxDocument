using DocumentModel.Drawings.ChartsStyle;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ChartStylePart
/// </summary>
public interface ChartStylePart: OpenXmlPart
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ChartStyle? ChartStyle { get; set; }

}