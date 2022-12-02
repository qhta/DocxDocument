namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommands Class.
/// </summary>
public interface IAllocatedCommands // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IAllocatedCommand>? AllocatedCommands { get ; set; }
  
}
