using DocumentModel.Drawings.Diagrams;

namespace DocumentModel.Drawings.Diagram1;
/// <summary>
///   Defines the NumberDiagramInfo Class.
/// </summary>
[OpenXmlType(typeof(DXO19DD1.NumberDiagramInfo))]
public partial class NumberDiagramInfo : ModelElement<DXO19DD1.NumberDiagramInfo>
{
  /// <summary>
  ///   lvl
  /// </summary>
  [OpenXmlProperty(nameof(DXO19DD1.NumberDiagramInfo.Lvl))]
  public UInt32? Lvl { get => _Lvl; set => UpdateField(ref _Lvl, value, nameof(Lvl)); }
  private UInt32? _Lvl;
  /// <summary>
  ///   ptType
  /// </summary>
  [OpenXmlProperty(nameof(DXO19DD1.NumberDiagramInfo.PtType))]
  public StorageType? PtType { get => _PtType; set => UpdateField(ref _PtType, value, nameof(PtType)); }
  private StorageType? _PtType;
  /// <summary>
  ///   DiagramAutoBullet.
  /// </summary>
  [OpenXmlProperty(nameof(DXO19DD1.NumberDiagramInfo.DiagramAutoBullet))]
  public DiagramAutoBullet? DiagramAutoBullet { get => _DiagramAutoBullet; set => UpdateField(ref _DiagramAutoBullet, value, nameof(DiagramAutoBullet)); }
  private DiagramAutoBullet? _DiagramAutoBullet;
}