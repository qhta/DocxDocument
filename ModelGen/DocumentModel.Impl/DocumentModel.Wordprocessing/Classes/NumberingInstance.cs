namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Definition Instance.
/// </summary>
public class NumberingInstanceImpl: ModelElementImpl, NumberingInstance
{
  public DocumentFormat.OpenXml.Wordprocessing.NumberingInstance? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.NumberingInstance?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// numId
  /// </summary>
  public Int32? NumberID
  {
    get;
    set;
  }
  
  /// <summary>
  /// durableId
  /// </summary>
  public Int32? DurableId
  {
    get;
    set;
  }
  
  /// <summary>
  /// AbstractNumId.
  /// </summary>
  public Int32? AbstractNumId
  {
    get;
    set;
  }
  
  public Collection<LevelOverride>? LevelOverrides
  {
    get;
    set;
  }
  
}
