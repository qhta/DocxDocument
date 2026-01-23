using DocumentModel.Math;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the presence of a hyperlink at the current location in a WordprocessingML document.
/// This class extends <see cref="IParagraphContent"/>, <see cref="ISdtRunContent"/>, <see cref="IBidirectionalContent"/>, and <see cref="IMathArgumentContent"/>, enabling advanced linking, navigation, and integration of hyperlinks within paragraphs, structured document tags, bidirectional content, and mathematical arguments.
/// </summary>
public abstract class Hyperlink<T> : ModelElement<T>,
  IParagraphContent,
  ISdtRunContent,
  IBidirectionalContent,
  DMM.IMathArgumentContent
where T : DX.OpenXmlElement
{

  /// <summary>
  /// Target frame for the hyperlink, specifying where the linked content should open.
  /// </summary>
  public string? TargetFrame { get; set; }

  /// <summary>
  /// Tooltip text associated with the hyperlink, providing additional information to users.
  /// </summary>
  public string? Tooltip { get; set; }

  /// <summary>
  /// Location in the target document to which the hyperlink points.
  /// </summary>
  public string? DocLocation { get; set; }

  /// <summary>
  /// Indicates whether the hyperlink should be added to the list of viewed hyperlinks (history).
  /// </summary>
  public bool? History { get; set; }

  /// <summary>
  /// Anchor within the target document for the hyperlink.
  /// </summary>
  public string? Anchor { get; set; }

  /// <summary>
  /// Target identifier for the hyperlink, referencing the external or internal resource.
  /// </summary>
  public string? Id { get; set; }
}
