namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommands Class.
/// </summary>
public interface IAllocatedCommands // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IAllocatedCommand>? AllocatedCommands { get ; set; }
  
}
