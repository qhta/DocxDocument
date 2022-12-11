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
  
  public AllocatedCommandsImpl(): base() {}
  
  public AllocatedCommandsImpl(DocumentFormat.OpenXml.Office.Word.AllocatedCommands openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<AllocatedCommand>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
