namespace DocumentModel.Drawings;
/// <summary>
/// Represents the outcome of a classification process, including the outcome type and any additional extension data.
/// </summary>
[OpenXmlType(typeof(DXO21DDC.ClassificationOutcome))]
[DataContract]
[XmlRoot("ClassificationOutcome", Namespace = "DocumentModel.Drawings")]
public partial class ClassificationOutcome : ModelElement<DXO21DDC.ClassificationOutcome>, IExtendableElement
{
  /// <summary>
  /// Classification outcome type.
  /// </summary>
  [OpenXmlProperty(nameof(DXO21DDC.ClassificationOutcome.ClassificationOutcomeType))]
  public ClassificationOutcomeType? ClassificationOutcomeType { get => _ClassificationOutcomeType ??= GetProperty<ClassificationOutcomeType?>(GetUpdatableElement()?.ClassificationOutcomeType); set => UpdateField(ref _ClassificationOutcomeType, value, nameof(ClassificationOutcomeType)); }
  private ClassificationOutcomeType? _ClassificationOutcomeType;

  /// <summary>
  /// List of extensions for additional data.
  /// </summary>
  public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
  private ExtensionList? _ExtensionList;
}