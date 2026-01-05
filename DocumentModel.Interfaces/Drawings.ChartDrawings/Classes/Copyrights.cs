namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a collection of copyright notices associated with chart data or content.
/// </summary>
/// <remarks>
///   This interface defines a container for copyright information
///   related to chart data, geographic information, images, or other content used in chart visualizations.
///   Copyright notices are important for legal attribution and intellectual property protection, particularly
///   when charts incorporate data from external sources, licensed geographic information, proprietary datasets,
///   or copyrighted images. The collection can contain multiple copyright strings to accommodate scenarios
///   where chart content is derived from multiple sources, each requiring separate attribution. These copyright
///   notices may be displayed within the chart, included in chart metadata, or used for documentation purposes.
///   Maintaining proper copyright information ensures legal compliance and appropriate attribution of data
///   sources, which is especially important for charts used in published documents, presentations, or
///   commercial applications.
/// </remarks>
public interface Copyrights :
{
  /// <summary>
  ///   Gets or sets the collection of copyright notice strings.
  /// </summary>
  /// <remarks>
  ///   Each string in the collection typically contains a complete copyright notice including the copyright
  ///   symbol (©), year, copyright holder name, and any additional rights or attribution information
  ///   (e.g., "© 2024 Company Name. All rights reserved." or "Data provided by XYZ Corporation").
  ///   Multiple copyright strings enable proper attribution when chart content is sourced from multiple
  ///   providers or when different chart elements (such as data, images, and geographic information) have
  ///   different copyright holders. The copyright information helps ensure legal compliance and proper
  ///   attribution in published or distributed charts.
  /// </remarks>
  public Collection<String>? CopyrightXsdStrings { get; set; }
}