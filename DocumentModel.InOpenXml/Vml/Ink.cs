namespace DocumentModel.Vml;

/// <summary>
///   Ink.
/// </summary>
[OpenXmlType(typeof(DXVO.Ink))]
[DataContract]
[XmlRoot("Ink", Namespace = "DocumentModel.Vml")]
public partial class Ink: ModelElement<DXVO.Ink>
{
  /// <summary>
  ///   Ink Data
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.Ink.InkData))]
  public Base64Binary? InkData
  {
    get => _InkData ??= GetProperty<Base64Binary?>(GetUpdatableElement()?.InkData);
    set => UpdateField(ref _InkData, value, nameof(InkData));
  }

  private Base64Binary? _InkData;

  /// <summary>
  ///   Annotation Flag
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.Ink.AnnotationFlag))]
  public bool? AnnotationFlag
  {
    get => _AnnotationFlag ??= GetProperty<bool?>(GetUpdatableElement()?.AnnotationFlag);
    set => UpdateField(ref _AnnotationFlag, value, nameof(AnnotationFlag));
  }

  private bool? _AnnotationFlag;
}