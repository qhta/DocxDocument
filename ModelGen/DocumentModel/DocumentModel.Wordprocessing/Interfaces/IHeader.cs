namespace DocumentModel.Wordprocessing;

/// <summary>
/// Header.
/// </summary>
public interface IHeader // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Gets the HeaderPart associated with this element.
  /// </summary>
  public IHeaderPart? HeaderPart { get ; set; }
  
}
