namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom XSL Transform To Use When Saving As XML File.
/// </summary>
public interface ISaveThroughXslt // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// XSL Transformation Location
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Local Identifier for XSL Transform
  /// </summary>
  public System.String? SolutionId { get ; set; }
  
}
