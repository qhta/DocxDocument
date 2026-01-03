namespace DocumentModel;

/// <summary>
/// Alternate content element that allows for multiple choices and a fallback.
/// </summary>
public interface IAlternateContent : IModelElement
{
  /// <summary>
  /// Gets or sets the selected alternate content choice for this instance.
  /// </summary>
  /// <remarks>Set this property to specify which alternate content option should be used. If no value is
  /// assigned, the default behavior is determined by the consuming logic.</remarks>
  public IAlternateContentChoiceCollection? Choices { get; set; }

  /// <summary>
  /// Gets or sets the fallback content to use when the primary content is unavailable or cannot be rendered.
  /// </summary>
  public IAlternateContentFallback? Fallback { get; set; }
}
