using DocumentModel.Drawings.Charts;

namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the OpenXmlTickMarksElement Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.OpenXmlTickMarksElement))]
[XmlRoot("OpenXmlTickMarksElement", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class OpenXmlTickMarksElement : ModelElement<DXO16DCD.OpenXmlTickMarksElement>
{
  /// <summary>
  /// Specifies the type.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.OpenXmlTickMarksElement.Type))]
  public TickMarksType? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

  private TickMarksType? _Type;
  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.OpenXmlTickMarksElement.ExtensionList))]
  public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

  private ExtensionList? _ExtensionList;
}