namespace DocumentModel.Presentation;

/// <summary>
/// Defines the TextStyles Class.
/// </summary>
public interface ITextStyles // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Slide Master Title Text Style.
  /// </summary>
  public DocumentModel.Presentation.ITextListStyleType? TitleStyle { get ; set; }
  
  /// <summary>
  /// Slide Master Body Text Style.
  /// </summary>
  public DocumentModel.Presentation.ITextListStyleType? BodyStyle { get ; set; }
  
  /// <summary>
  /// Slide Master Other Text Style.
  /// </summary>
  public DocumentModel.Presentation.ITextListStyleType? OtherStyle { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
