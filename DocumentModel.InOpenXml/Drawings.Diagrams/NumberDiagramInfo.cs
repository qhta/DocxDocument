namespace DocumentModel.Drawings.Diagram1;
/// <summary>
///   Defines the NumberDiagramInfo Class.
/// </summary>
[OpenXmlType(typeof(DXO19DD1.NumberDiagramInfo))]
/// <summary>
/// Represents the Number Diagram Info.
/// </summary>
public class NumberDiagramInfo : ModelElement<DXO19DD1.NumberDiagramInfo>
{
 /// <summary>
 ///   lvl
 /// </summary>
 [OpenXmlProperty(nameof(DXO19DD1.NumberDiagramInfo.Lvl))]
 /// <summary>
 /// Lvl.
 /// </summary>
 public UInt32? Lvl { get; set; }

 /// <summary>
 ///   ptType
 /// </summary>
 [OpenXmlProperty(nameof(DXO19DD1.NumberDiagramInfo.PtType))]
 /// <summary>
 /// Pt Type.
 /// </summary>
 public STorageType? PtType { get; set; }

 /// <summary>
 ///   DiagramAutoBullet.
 /// </summary>
 [OpenXmlProperty(nameof(DXO19DD1.NumberDiagramInfo.DiagramAutoBullet))]
 /// <summary>
 /// Diagram Auto Bullet.
 /// </summary>
 public DiagramAutoBullet? DiagramAutoBullet { get; set; }
}

