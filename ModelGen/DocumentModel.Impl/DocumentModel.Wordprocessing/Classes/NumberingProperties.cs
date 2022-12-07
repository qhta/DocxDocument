namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the NumberingProperties Class.
/// </summary>
public class NumberingPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.NumberingProperties>, NumberingProperties
{
  /// <summary>
  /// Previous Paragraph Numbering Properties.
  /// </summary>
  public NumberingChange? NumberingChange
  {
    get;
    set;
  }
  
}
