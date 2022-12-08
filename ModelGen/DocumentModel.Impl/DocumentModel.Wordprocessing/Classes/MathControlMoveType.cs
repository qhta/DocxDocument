namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MathControlMoveType Class.
/// </summary>
public class MathControlMoveTypeImpl: ModelElementImpl, MathControlMoveType
{
  public DocumentFormat.OpenXml.Wordprocessing.MathControlMoveType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.MathControlMoveType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// author
  /// </summary>
  public String? Author
  {
    get;
    set;
  }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date
  {
    get;
    set;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
}
