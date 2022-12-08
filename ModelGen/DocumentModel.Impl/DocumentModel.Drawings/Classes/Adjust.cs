namespace DocumentModel.Drawings;

/// <summary>
/// Shape Adjust.
/// </summary>
public class AdjustImpl: ModelElementImpl, Adjust
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Adjust? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Adjust?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Adjust Handle Index
  /// </summary>
  public UInt32? Index
  {
    get;
    set;
  }
  
  /// <summary>
  /// Value
  /// </summary>
  public Double? Val
  {
    get;
    set;
  }
  
}
