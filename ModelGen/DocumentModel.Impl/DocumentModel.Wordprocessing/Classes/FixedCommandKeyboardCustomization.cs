namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FixedCommandKeyboardCustomization Class.
/// </summary>
public partial class FixedCommandKeyboardCustomizationImpl: ModelElementImpl, FixedCommandKeyboardCustomization
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public FixedCommandKeyboardCustomizationImpl(): base() {}
  
  public FixedCommandKeyboardCustomizationImpl(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// fciName
  /// </summary>
  public String? CommandName
  {
    get => (System.String?)OpenXmlElement?.CommandName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CommandName = (System.String?)value;
    }
  }
  
  /// <summary>
  /// fciIndex
  /// </summary>
  public DocumentModel.HexBinary? CommandIndex
  {
    get
    {
      if (OpenXmlElement?.CommandIndex?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.CommandIndex.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.CommandIndex = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.CommandIndex = null;
      }
    }
  }
  
  /// <summary>
  /// swArg
  /// </summary>
  public DocumentModel.HexBinary? Argument
  {
    get
    {
      if (OpenXmlElement?.Argument?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.Argument.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.Argument = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.Argument = null;
      }
    }
  }
  
}
