namespace DocumentModel.Presentation;

/// <summary>
/// Programmable Tab List.
/// </summary>
public interface ITagList // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Gets the UserDefinedTagsPart associated with this element.
  /// </summary>
  public UserDefinedTagsPart? UserDefinedTagsPart { get ; set; }
  
}
