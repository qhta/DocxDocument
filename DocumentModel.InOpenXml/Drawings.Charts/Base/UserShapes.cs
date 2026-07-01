using DocumentFormat.OpenXml.EMMA;
using DocumentModel.Drawings.ChartDrawing;

namespace DocumentModel.Drawings.Charts;
/// <summary>
///   User Shapes.
/// </summary>
/// <remarks>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.AbsoluteAnchorSize"/> <c>&lt;cdr:absSizeAnchor&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize"/> <c>&lt;cdr:relSizeAnchor&gt;</c></description></item>
/// </list>
/// </remarks>
[OpenXmlType(typeof(DXDC.UserShapes))]
[DataContract]
[XmlRoot("UserShapes", Namespace = "DocumentModel.Drawings.Charts")]
public partial class UserShapes : ModelElement<DXDC.UserShapes>
{
 /// <summary>
 /// Relative Anchor Size of the user shape, defining how the shape's size is determined relative to its anchor point.
 /// </summary>
 [OpenXmlElement(typeof(DXDCD.RelativeAnchorSize))]
 public RelativeAnchorSize? RelativeAnchorSize { get => _RelativeAnchorSize; set => UpdateField(ref _RelativeAnchorSize, value, nameof(RelativeAnchorSize)); }
 private RelativeAnchorSize? _RelativeAnchorSize;

 /// <summary>
 /// Absolute Anchor Size of the user shape, specifying the shape's size in absolute terms regardless of its anchor point.
 /// </summary>
 [OpenXmlElement(typeof(DXDCD.AbsoluteAnchorSize))]
 public AbsoluteAnchorSize? AbsoluteAnchorSize { get => _AbsoluteAnchorSize; set => UpdateField(ref _AbsoluteAnchorSize, value, nameof(AbsoluteAnchorSize)); }
 private AbsoluteAnchorSize? _AbsoluteAnchorSize;
}