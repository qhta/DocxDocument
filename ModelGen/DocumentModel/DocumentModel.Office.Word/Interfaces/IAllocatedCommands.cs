namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the AllocatedCommands Class.
/// </summary>
public interface IAllocatedCommands // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office.Word.IAllocatedCommand>? AllocatedCommands { get ; set; }
  
}
