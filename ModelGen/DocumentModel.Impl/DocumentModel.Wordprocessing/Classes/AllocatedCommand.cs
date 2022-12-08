namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommand Class.
/// </summary>
public class AllocatedCommandImpl: ModelElementImpl, AllocatedCommand
{
  public DocumentFormat.OpenXml.Office.Word.AllocatedCommand? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.AllocatedCommand?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// argValue
  /// </summary>
  public String? ArgumentValue
  {
    get;
    set;
  }
  
  /// <summary>
  /// fciBasedOn
  /// </summary>
  public String? CommandBasedOn
  {
    get;
    set;
  }
  
  /// <summary>
  /// fciIndexBasedOn
  /// </summary>
  public DocumentModel.HexBinaryValue? CommandIndexBasedOn
  {
    get;
    set;
  }
  
  /// <summary>
  /// acdName
  /// </summary>
  public String? AcceleratorName
  {
    get;
    set;
  }
  
}
