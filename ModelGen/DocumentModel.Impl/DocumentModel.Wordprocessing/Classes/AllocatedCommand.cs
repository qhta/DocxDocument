namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommand Class.
/// </summary>
public partial class AllocatedCommandImpl: ModelElementImpl, AllocatedCommand
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
  public DocumentModel.HexBinary? CommandIndexBasedOn
  {
    get
    {
      if (OpenXmlElement?.CommandIndexBasedOn?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.CommandIndexBasedOn.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.CommandIndexBasedOn = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.CommandIndexBasedOn = null;
      }
    }
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
