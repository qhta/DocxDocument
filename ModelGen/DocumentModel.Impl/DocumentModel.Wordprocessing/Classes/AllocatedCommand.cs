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
  
  public AllocatedCommandImpl(): base() {}
  
  public AllocatedCommandImpl(DocumentFormat.OpenXml.Office.Word.AllocatedCommand openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// argValue
  /// </summary>
  public String? ArgumentValue
  {
    get => (System.String?)OpenXmlElement?.ArgumentValue?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ArgumentValue = (System.String?)value;
    }
  }
  
  /// <summary>
  /// fciBasedOn
  /// </summary>
  public String? CommandBasedOn
  {
    get => (System.String?)OpenXmlElement?.CommandBasedOn?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CommandBasedOn = (System.String?)value;
    }
  }
  
  /// <summary>
  /// fciIndexBasedOn
  /// </summary>
  public DocumentModel.HexBinaryValue? CommandIndexBasedOn
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// acdName
  /// </summary>
  public String? AcceleratorName
  {
    get => (System.String?)OpenXmlElement?.AcceleratorName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AcceleratorName = (System.String?)value;
    }
  }
  
}
