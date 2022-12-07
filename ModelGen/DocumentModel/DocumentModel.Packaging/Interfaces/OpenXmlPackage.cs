namespace DocumentModel.Packaging;

/// <summary>
/// Represents a base class for strong typed Open XML document classes.
/// </summary>
public interface OpenXmlPackage
{
  /// <summary>
  /// Gets all the  parts in the document package.
  /// </summary>
  public DataPart? DataParts { get ; set; }
  
  /// <summary>
  /// Gets the markup compatibility settings applied at loading time.
  /// </summary>
  public MarkupCompatibilityProcessSettings? MarkupCompatibilityProcessSettings { get ; set; }
  
}
