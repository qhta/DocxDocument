namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the People Class.
/// </summary>
public interface IPeople // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Gets the WordprocessingPeoplePart associated with this element.
  /// </summary>
  public WordprocessingPeoplePart? WordprocessingPeoplePart { get ; set; }
  
}
