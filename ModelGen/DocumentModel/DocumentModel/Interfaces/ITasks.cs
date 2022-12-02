namespace DocumentModel;

/// <summary>
/// Defines the Tasks Class.
/// </summary>
public interface ITasks // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<ITask>? Tasks { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
