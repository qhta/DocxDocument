namespace DocumentModel.Drawings;

/// <summary>
/// Represents build diagram options, including build type, reverse animation, and additional extension settings for diagram elements.
/// </summary>
[OpenXmlType(typeof(DXD.BuildDiagram))]
[DataContract]
[XmlRoot("BuildDiagram", Namespace = "DocumentModel.Drawings")]
public partial class BuildDiagram: ModelElement<DXD.BuildDiagram> // , ExtendableElement
{
  /// <summary>
  /// Build type or sequence for the diagram.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.BuildDiagram.Build))]
  public string? Build
  {
    get => _Build ??= GetProperty<string?>(GetUpdatableElement()?.Build);
    set => UpdateField(ref _Build, value, nameof(Build));
  }

  private string? _Build;

  /// <summary>
  /// Indicates whether the animation should be reversed.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.BuildDiagram.ReverseAnimation))]
  public bool? ReverseAnimation
  {
    get => _ReverseAnimation ??= GetProperty<bool?>(GetUpdatableElement()?.ReverseAnimation);
    set => UpdateField(ref _ReverseAnimation, value, nameof(ReverseAnimation));
  }

  private bool? _ReverseAnimation;
}