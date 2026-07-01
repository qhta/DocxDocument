namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a collection of copyright notices associated with chart data or content.
/// </summary>
/// <remarks>
///   This class defines a container for copyright information
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
[DataContract]
[XmlRoot("Copyrights", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class Copyrights : StringList
{
}