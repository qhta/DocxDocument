namespace DocumentModel.Drawings.Diagram1;
/// <summary>
///   Defines the NumberDiagramInfo Class.
/// </summary>
[OpenXmlType(typeof(DXO19DD1.NumberDiagramInfo))]
public class NumberDiagramInfo : ModelElement<DXO19DD1.NumberDiagramInfo>
{
 /// <summary>
 ///   lvl
 /// </summary>
 [OpenXmlProperty(nameof(DXO19DD1.NumberDiagramInfo.Lvl))]
 public UInt32? Lvl { get; set; }

 /// <summary>
 ///   ptType
 /// </summary>
 [OpenXmlProperty(nameof(DXO19DD1.NumberDiagramInfo.PtType))]
 public STorageType? PtType { get; set; }

 /// <summary>
 ///   DiagramAutoBullet.
 /// </summary>
 [OpenXmlProperty(nameof(DXO19DD1.NumberDiagramInfo.DiagramAutoBullet))]
 public DiagramAutoBullet? DiagramAutoBullet { get; set; }
}