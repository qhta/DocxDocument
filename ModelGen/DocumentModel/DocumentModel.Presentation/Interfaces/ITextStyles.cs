namespace DocumentModel.Presentation;

/// <summary>
/// Defines the TextStyles Class.
/// </summary>
public interface ITextStyles // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Slide Master Title Text Style.
  /// </summary>
  public DocumentModel.Presentation.ITitleStyle? TitleStyle { get ; set; }
  
  /// <summary>
  /// Slide Master Body Text Style.
  /// </summary>
  public DocumentModel.Presentation.IBodyStyle? BodyStyle { get ; set; }
  
  /// <summary>
  /// Slide Master Other Text Style.
  /// </summary>
  public DocumentModel.Presentation.IOtherStyle? OtherStyle { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }
  
}
