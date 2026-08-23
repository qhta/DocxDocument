namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the NonVisualInkContentPartProperties Class.
/// </summary>
[OpenXmlType(typeof(DXO10DCD.NonVisualInkContentPartProperties))]
[DataContract]
[XmlRoot("NonVisualInkContentPartProperties", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class NonVisualInkContentPartProperties: ModelElement<DXO10DCD.NonVisualInkContentPartProperties>
{
  /// <summary>
  /// Specifies the is comment.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DCD.NonVisualInkContentPartProperties.IsComment))]
  public bool? IsComment
  {
    get => _IsComment ??= GetProperty<bool?>(GetUpdatableElement()?.IsComment);
    set => UpdateField(ref _IsComment, value, nameof(IsComment));
  }

  private bool? _IsComment;

  /// <summary>
  /// Specifies the content part locks.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DCD.NonVisualInkContentPartProperties.ContentPartLocks))]
  public ContentPartLocks? ContentPartLocks
  {
    get => _ContentPartLocks ??= GetProperty<ContentPartLocks?>(GetUpdatableElement()?.ContentPartLocks);
    set => UpdateField(ref _ContentPartLocks, value, nameof(ContentPartLocks));
  }

  private ContentPartLocks? _ContentPartLocks;

  /// <summary>
  /// Specifies the office art extension list.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DCD.NonVisualInkContentPartProperties.OfficeArtExtensionList))]
  public OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => _OfficeArtExtensionList ??=
      GetProperty<OfficeArtExtensionList?>(GetUpdatableElement()?.OfficeArtExtensionList);
    set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList));
  }

  private OfficeArtExtensionList? _OfficeArtExtensionList;
}