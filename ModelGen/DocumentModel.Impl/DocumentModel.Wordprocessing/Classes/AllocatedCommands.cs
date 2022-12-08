namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommands Class.
/// </summary>
public class AllocatedCommandsImpl: ModelElementImpl, AllocatedCommands
{
  public DocumentFormat.OpenXml.Office.Word.AllocatedCommands? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.AllocatedCommands?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<AllocatedCommand>? Items
  {
    get;
    set;
  }
  
}
