namespace DocumentModel.Presentation;

/// <summary>
/// Defines the TextStyles Class.
/// </summary>
public interface ITextStyles // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Slide Master Title Text Style.
  /// </summary>
  public ITitleStyle? TitleStyle { get ; set; }
  
  /// <summary>
  /// Slide Master Body Text Style.
  /// </summary>
  public IBodyStyle? BodyStyle { get ; set; }
  
  /// <summary>
  /// Slide Master Other Text Style.
  /// </summary>
  public IOtherStyle? OtherStyle { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
