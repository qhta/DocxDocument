namespace DocumentModel.Presentation;

/// <summary>
/// Defines the TextStyles Class.
/// </summary>
public interface TextStyles // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Slide Master Title Text Style.
  /// </summary>
  public TitleStyle? TitleStyle { get ; set; }
  
  /// <summary>
  /// Slide Master Body Text Style.
  /// </summary>
  public BodyStyle? BodyStyle { get ; set; }
  
  /// <summary>
  /// Slide Master Other Text Style.
  /// </summary>
  public OtherStyle? OtherStyle { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
