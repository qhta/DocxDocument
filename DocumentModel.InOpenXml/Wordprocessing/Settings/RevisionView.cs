namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the visibility settings for annotation types in a Wordprocessing document.
/// This class provides properties for controlling the display of markup areas, comments, content revisions, formatting revisions, and ink annotations, enabling advanced configuration of revision and annotation visibility.
/// </summary>
[DataContract]
[XmlRoot("RevisionView", Namespace = "DocumentModel.Wordprocessing")]
public partial class RevisionView : ModelElement<DXW.RevisionView>
{
  /// <summary>
  /// Display visual indicator of the markup area.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.RevisionView.Markup))]
  public bool? Markup 
  { 
    get => _Markup ?? GetProperty<bool?>(GetUpdatableElement()?.Markup); 
    set => UpdateField(ref _Markup, value, nameof(Markup));
  }
  private bool? _Markup;

  /// <summary>
  /// Display comments in the document.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.RevisionView.Comments))]
  public bool? Comments 
  { 
    get => _Comments ?? GetProperty<bool?>(GetUpdatableElement()?.Comments); 
    set => UpdateField(ref _Comments, value, nameof(Comments));
  }
  private bool? _Comments;

  /// <summary>
  /// Display content revisions in the document.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.RevisionView.DisplayRevision))]
  public bool? DisplayRevision
  {
    get => _DisplayRevision ?? GetProperty<bool?>(GetUpdatableElement()?.DisplayRevision);
    set => UpdateField(ref _DisplayRevision, value, nameof(DisplayRevision));
  }
  private bool? _DisplayRevision;

  /// <summary>
  /// Display formatting revisions in the document.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.RevisionView.Formatting))]
  public bool? Formatting
  {
    get => _Formatting ?? GetProperty<bool?>(GetUpdatableElement()?.Formatting);
    set => UpdateField(ref _Formatting, value, nameof(Formatting));
  }
  private bool? _Formatting;

  /// <summary>
  /// Display ink annotations in the document.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.RevisionView.InkAnnotations))]
  public bool? InkAnnotations 
  {
    get => _InkAnnotations ?? GetProperty<bool?>(GetUpdatableElement()?.InkAnnotations);
    set => UpdateField(ref _InkAnnotations, value, nameof(InkAnnotations));
  }
  private bool? _InkAnnotations;
}
