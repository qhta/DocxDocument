using DocumentModel.Drawings.Diagram1;

namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Defines the DiagramDefinitionExtension Class.
/// </summary>
[OpenXmlType(typeof(DXDD.DiagramDefinitionExtension))]
[DataContract]
[XmlRoot("DiagramDefinitionExtension", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class DiagramDefinitionExtension : Extension<DXDD.DiagramDefinitionExtension>
{
  /// <summary>
  /// Number Diagram Info List.
  /// </summary>
  [OpenXmlElement(typeof(DXO19DD1.NumberDiagramInfoList))]
  public NumberDiagramInfoList? NumberDiagramInfoList { get => _NumberDiagramInfoList; set => UpdateField(ref _NumberDiagramInfoList, value, nameof(NumberDiagramInfoList)); }
  private NumberDiagramInfoList? _NumberDiagramInfoList;

  /// <summary>
  /// Text List Style Type.
  /// </summary>
  [OpenXmlElement(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType))]
  public ListStyle? TextListStyleType { get => _TextListStyleType; set => UpdateField(ref _TextListStyleType, value, nameof(TextListStyleType)); }
  private ListStyle? _TextListStyleType;
}